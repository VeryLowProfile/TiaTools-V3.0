using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TiaTools_V3._0.Workers;
using TopSharpExcel = TopSharp_NetFramework.EXCEL.Excel;
using TopSharpCsv = TopSharp_NetFramework.CSV.Csv;

namespace TiaTools_V3._0.Forms
{
    public partial class Form_Messages : Form
    {
        public Form_Messages()
        {
            InitializeComponent();
        }

        private void Form_Messages_Load(object sender, System.EventArgs e)
        {
            checkBox_LoadExcel.Checked = true;
            checkBox_LoadCsv.Checked = false;
            checkBox_CreateExcel.Checked = true;
            checkBox_CreateCsv.Checked = false;
        }

        private void checkBox_Csv_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox_LoadCsv.Checked)
            {
                checkBox_LoadExcel.Checked = false;
            }
        }

        private void checkBox_Excel_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox_LoadExcel.Checked)
            {
                checkBox_LoadCsv.Checked = false;
            }
        }

        private void checkBox_CreateCsv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CreateCsv.Checked)
            {
                checkBox_CreateExcel.Checked = false;
            }
        }

        private void checkBox_CreateExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CreateExcel.Checked)
            {
                checkBox_CreateCsv.Checked = false;
            }
        }

        private void button_SelectFile_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (checkBox_LoadExcel.Checked)
            {
                openFileDialog.Filter = "Excel Workbook|*.xls; *xlsx";
                openFileDialog.Title = "Select an Excel message table";
            }
            else if (checkBox_LoadCsv.Checked)
            {
                openFileDialog.Filter = "Csv file|*.csv";
                openFileDialog.Title = "Select a CSV message table";
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_ImportFilePath.Text = openFileDialog.FileName;
            }
        }

        private void buttonImport_Click(object sender, System.EventArgs e)
        {
            DataTable dataTable = new DataTable();
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = true;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            try
            {
                if (checkBox_LoadExcel.Checked)
                {
                    dataTable = TopSharpExcel.ExcelToDataTable(textBox_ImportFilePath.Text, 1);
                }
                else if (checkBox_LoadCsv.Checked)
                {
                    dataTable = TopSharpCsv.CsvToDataTable(textBox_ImportFilePath.Text, ';');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form_Messages.buttonImport_Click " + ex.Message);
            }

            dataGridView.DataSource = dataTable;
            dataGridView.Update();
            panel_DataGridView.Controls.Add(dataGridView);
        }

        private void buttonCreateFiles_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();
            DataTable processedDataTable = new DataTable();
            DataGridView dataGridView = new DataGridView();

            try
            {
                dataGridView = (DataGridView)panel_DataGridView.Controls[0];
                dataTable = (DataTable)dataGridView.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form_Messages.buttonCreateFiles_Click " + ex.Message);
            }

            processedDataTable = MessagesWorkers.ProcessedMessagesToDataTable(dataTable);

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                //Get filePath
                string filePath = folderBrowserDialog.SelectedPath + @"\TIA_SourceFile_Messages" + DateTime.Now.ToString().Replace("/", "_").Replace(" ", "_").Replace(":", "_");

                //Create New Directory
                try
                {                   
                    Directory.CreateDirectory(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_Messages.buttonCreateFiles_Click " + ex.Message);
                }


                //Print Msg_Config Table
                if (checkBox_CreateExcel.Checked) //Excel
                {
                    try
                    {
                        TopSharpExcel.DataTableToExcel(processedDataTable, filePath + @"\Msg_Config.xlsx");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Form_Messages.buttonCreateFiles_Click " + ex.Message);
                    }
                }
                else if (checkBox_CreateCsv.Checked) //Csv
                {
                    try
                    {
                        TopSharpCsv.DataTableToCsv(processedDataTable, filePath + @"\Msg_Config.csv", ';');
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Form_Messages.buttonCreateFiles_Click " + ex.Message);
                    }
                }

                //Print Fc_Msg_Trigger
                try
                {
                    MessagesWorkers.PrintFcMessageTrigger(processedDataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_Messages.buttonCreateFiles_Click.PrintFcMessageTrigger " + ex.Message);
                }

                //Print FC_Msg_Config
                try
                {
                    MessagesWorkers.PrintFcMessageConfig(processedDataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_Messages.buttonCreateFiles_Click.PrintFcMessageConfig " + ex.Message);
                }

                //Print DB_Msg
                try
                {
                    MessagesWorkers.PrintDB_Msg(processedDataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_Messages.buttonCreateFiles_Click.PrintDB_Msg " + ex.Message);
                }
            }
        }
    }
}
