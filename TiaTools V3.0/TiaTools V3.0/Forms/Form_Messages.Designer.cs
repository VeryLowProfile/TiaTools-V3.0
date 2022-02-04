using System.Threading.Tasks;

namespace TiaTools_V3._0.Forms
{
    partial class Form_Messages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_BackGround = new System.Windows.Forms.TableLayoutPanel();
            this.panel_DataGridView = new System.Windows.Forms.Panel();
            this.panel_Functions = new System.Windows.Forms.Panel();
            this.checkBox_CreateCsv = new System.Windows.Forms.CheckBox();
            this.checkBox_CreateExcel = new System.Windows.Forms.CheckBox();
            this.checkBox_LoadCsv = new System.Windows.Forms.CheckBox();
            this.checkBox_LoadExcel = new System.Windows.Forms.CheckBox();
            this.buttonCreateFiles = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.textBox_ImportFilePath = new System.Windows.Forms.TextBox();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.tableLayoutPanel_BackGround.SuspendLayout();
            this.panel_Functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_BackGround
            // 
            this.tableLayoutPanel_BackGround.ColumnCount = 1;
            this.tableLayoutPanel_BackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_BackGround.Controls.Add(this.panel_DataGridView, 0, 0);
            this.tableLayoutPanel_BackGround.Controls.Add(this.panel_Functions, 0, 1);
            this.tableLayoutPanel_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_BackGround.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_BackGround.Name = "tableLayoutPanel_BackGround";
            this.tableLayoutPanel_BackGround.RowCount = 2;
            this.tableLayoutPanel_BackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_BackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_BackGround.Size = new System.Drawing.Size(851, 723);
            this.tableLayoutPanel_BackGround.TabIndex = 0;
            // 
            // panel_DataGridView
            // 
            this.panel_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.panel_DataGridView.Name = "panel_DataGridView";
            this.panel_DataGridView.Size = new System.Drawing.Size(845, 608);
            this.panel_DataGridView.TabIndex = 0;
            // 
            // panel_Functions
            // 
            this.panel_Functions.Controls.Add(this.checkBox_CreateCsv);
            this.panel_Functions.Controls.Add(this.checkBox_CreateExcel);
            this.panel_Functions.Controls.Add(this.checkBox_LoadCsv);
            this.panel_Functions.Controls.Add(this.checkBox_LoadExcel);
            this.panel_Functions.Controls.Add(this.buttonCreateFiles);
            this.panel_Functions.Controls.Add(this.buttonImport);
            this.panel_Functions.Controls.Add(this.textBox_ImportFilePath);
            this.panel_Functions.Controls.Add(this.button_SelectFile);
            this.panel_Functions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Functions.Location = new System.Drawing.Point(3, 617);
            this.panel_Functions.Name = "panel_Functions";
            this.panel_Functions.Size = new System.Drawing.Size(845, 103);
            this.panel_Functions.TabIndex = 1;
            // 
            // checkBox_CreateCsv
            // 
            this.checkBox_CreateCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_CreateCsv.AutoSize = true;
            this.checkBox_CreateCsv.Location = new System.Drawing.Point(688, 48);
            this.checkBox_CreateCsv.Name = "checkBox_CreateCsv";
            this.checkBox_CreateCsv.Size = new System.Drawing.Size(46, 17);
            this.checkBox_CreateCsv.TabIndex = 23;
            this.checkBox_CreateCsv.Text = ".csv";
            this.checkBox_CreateCsv.UseVisualStyleBackColor = true;
            this.checkBox_CreateCsv.CheckedChanged += new System.EventHandler(this.checkBox_CreateCsv_CheckedChanged);
            // 
            // checkBox_CreateExcel
            // 
            this.checkBox_CreateExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_CreateExcel.AutoSize = true;
            this.checkBox_CreateExcel.Location = new System.Drawing.Point(740, 48);
            this.checkBox_CreateExcel.Name = "checkBox_CreateExcel";
            this.checkBox_CreateExcel.Size = new System.Drawing.Size(46, 17);
            this.checkBox_CreateExcel.TabIndex = 22;
            this.checkBox_CreateExcel.Text = ".xlsx";
            this.checkBox_CreateExcel.UseVisualStyleBackColor = true;
            this.checkBox_CreateExcel.CheckedChanged += new System.EventHandler(this.checkBox_CreateExcel_CheckedChanged);
            // 
            // checkBox_LoadCsv
            // 
            this.checkBox_LoadCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_LoadCsv.AutoSize = true;
            this.checkBox_LoadCsv.Location = new System.Drawing.Point(11, 24);
            this.checkBox_LoadCsv.Name = "checkBox_LoadCsv";
            this.checkBox_LoadCsv.Size = new System.Drawing.Size(46, 17);
            this.checkBox_LoadCsv.TabIndex = 21;
            this.checkBox_LoadCsv.Text = ".csv";
            this.checkBox_LoadCsv.UseVisualStyleBackColor = true;
            this.checkBox_LoadCsv.CheckedChanged += new System.EventHandler(this.checkBox_Csv_CheckedChanged);
            // 
            // checkBox_LoadExcel
            // 
            this.checkBox_LoadExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_LoadExcel.AutoSize = true;
            this.checkBox_LoadExcel.Location = new System.Drawing.Point(63, 24);
            this.checkBox_LoadExcel.Name = "checkBox_LoadExcel";
            this.checkBox_LoadExcel.Size = new System.Drawing.Size(46, 17);
            this.checkBox_LoadExcel.TabIndex = 20;
            this.checkBox_LoadExcel.Text = ".xlsx";
            this.checkBox_LoadExcel.UseVisualStyleBackColor = true;
            this.checkBox_LoadExcel.CheckedChanged += new System.EventHandler(this.checkBox_Excel_CheckedChanged);
            // 
            // buttonCreateFiles
            // 
            this.buttonCreateFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateFiles.Location = new System.Drawing.Point(687, 70);
            this.buttonCreateFiles.Name = "buttonCreateFiles";
            this.buttonCreateFiles.Size = new System.Drawing.Size(150, 25);
            this.buttonCreateFiles.TabIndex = 14;
            this.buttonCreateFiles.Text = "Create Files";
            this.buttonCreateFiles.UseVisualStyleBackColor = true;
            this.buttonCreateFiles.Click += new System.EventHandler(this.buttonCreateFiles_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImport.Location = new System.Drawing.Point(416, 70);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(150, 25);
            this.buttonImport.TabIndex = 10;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // textBox_ImportFilePath
            // 
            this.textBox_ImportFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_ImportFilePath.Location = new System.Drawing.Point(7, 72);
            this.textBox_ImportFilePath.Name = "textBox_ImportFilePath";
            this.textBox_ImportFilePath.Size = new System.Drawing.Size(403, 20);
            this.textBox_ImportFilePath.TabIndex = 9;
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SelectFile.Location = new System.Drawing.Point(7, 44);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(150, 25);
            this.button_SelectFile.TabIndex = 8;
            this.button_SelectFile.Text = "Select Message Table";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // Form_Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 723);
            this.Controls.Add(this.tableLayoutPanel_BackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Messages";
            this.Text = "Form_Messages";
            this.Load += new System.EventHandler(this.Form_Messages_Load);
            this.tableLayoutPanel_BackGround.ResumeLayout(false);
            this.panel_Functions.ResumeLayout(false);
            this.panel_Functions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_BackGround;
        private System.Windows.Forms.Panel panel_DataGridView;
        private System.Windows.Forms.Panel panel_Functions;
        private System.Windows.Forms.CheckBox checkBox_LoadCsv;
        private System.Windows.Forms.CheckBox checkBox_LoadExcel;
        private System.Windows.Forms.Button buttonCreateFiles;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.TextBox textBox_ImportFilePath;
        private System.Windows.Forms.Button button_SelectFile;
        private System.Windows.Forms.CheckBox checkBox_CreateCsv;
        private System.Windows.Forms.CheckBox checkBox_CreateExcel;
    }
}