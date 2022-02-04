using System;
using System.IO;
using System.Data;
using TiaTools_V3._0.Workers;
using System.Windows.Forms;
using TopSharpExcel = TopSharp_NetFramework.EXCEL.Excel;

namespace TiaTools_V3._0.Forms
{
    public partial class Form_ReportManager : Form
    {
        public Form_ReportManager()
        {
            InitializeComponent();
        }

        private void button_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Workbook|*.xls; *xlsx";
            openFileDialog.Title = "Select an Excel message table";

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
                dataTable = TopSharpExcel.ExcelToDataTable(textBox_ImportFilePath.Text, 1);
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
                MessageBox.Show("Form_RemortManager.buttonCreateFiles_Click " + ex.Message);
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {

                //Get filePath
                string filePath = folderBrowserDialog.SelectedPath + @"\ReportManager_Config" + DateTime.Now.ToString().Replace("/", "_").Replace(" ", "_").Replace(":", "_");

                //Create New Directory
                try
                {
                    Directory.CreateDirectory(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_RemortManager.buttonCreateFiles_Click " + ex.Message);
                }

                //Print AlarmsConfig.xml
                try
                {
                    ReportManagerWorkers.PrintReportManagerMsgconfig(dataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_RemortManager.buttonCreateFiles_Click.PrintReportManagerMsgconfig " + ex.Message);
                }

                //Print EventsConfig.xml
                try
                {
                    ReportManagerWorkers.PrintReportManagerEventconfig(dataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_RemortManager.buttonCreateFiles_Click.PrintReportManagerEventconfig " + ex.Message);
                }

                //Print LogVarConfig.xml
                try
                {
                    ReportManagerWorkers.PrintReportManagerLogVarconfig(dataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_RemortManager.buttonCreateFiles_Click.PrintReportManagerLogVarconfig " + ex.Message);
                }

                //Print AppConfig.xml
                try
                {
                    ReportManagerWorkers.PrintReportManagerAppconfig(dataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_RemortManager.buttonCreateFiles_Click.PrintReportManagerAppconfig " + ex.Message);
                }

                //Print FC_Sql_VarLink.scl
                try
                {
                    ReportManagerWorkers.PrintFcSqlVarLink(dataTable, filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form_RemortManager.buttonCreateFiles_Click.PrintFcSqlVarLink " + ex.Message);
                }
            }
        }
    }
}
