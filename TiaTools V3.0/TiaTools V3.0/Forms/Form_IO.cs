using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TiaTools_V3._0.Workers;
using TopSharpExcel = TopSharp_NetFramework.EXCEL.Excel;
using TopSharpCsv = TopSharp_NetFramework.CSV.Csv;

namespace TiaTools_V3._0.Forms
{
    public partial class Form_IO : Form
    {
        public Form_IO()
        {
            InitializeComponent();
        }

        private void Form_IO_Load(object sender, EventArgs e)
        {
            checkBox_LoadExcel.Checked = true;
            checkBox_LoadCsv.Checked = false;
        }

        private void checkBox_LoadCsv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LoadCsv.Checked)
            {
                checkBox_LoadExcel.Checked = false;
            }
        }

        private void checkBox_LoadExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LoadExcel.Checked)
            {
                checkBox_LoadCsv.Checked = false;
            }
        }

        private void button_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (checkBox_LoadExcel.Checked)
            {
                openFileDialog.Filter = "Excel Workbook|*.xls; *xlsx";
                openFileDialog.Title = "Select an Excel IO table";
            }
            else if (checkBox_LoadCsv.Checked)
            {
                openFileDialog.Filter = "Csv file|*.csv";
                openFileDialog.Title = "Select a CSV IO table";
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_ImportFilePath.Text = openFileDialog.FileName;
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
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
                MessageBox.Show("Form_IO.buttonCreateFiles_Click " + ex.Message);
            }

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
                    MessageBox.Show("Form_IO.buttonCreateFiles_Click " + ex.Message);
                }

                //Print Fc_IO
                try
                {
                    //Print DI Files
                    IoWorkers.PrintFcDi(dataTable, filePath);
                    IoWorkers.ProntFcDiConfig(dataTable, filePath);
                    IoWorkers.PrintDiInstances(dataTable, filePath);

                    //Print DQ Files
                    IoWorkers.PrintFcDq(dataTable, filePath);
                    IoWorkers.ProntFcDqConfig(dataTable, filePath);
                    IoWorkers.PrintDqInstances(dataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_IO.buttonCreateFiles_Click " + ex.Message);
                }
            }
        }
    }
}
