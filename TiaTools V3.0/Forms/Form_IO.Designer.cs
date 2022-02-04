
namespace TiaTools_V3._0.Forms
{
    partial class Form_IO
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
            this.tableLayoutPanel_BackGround.Size = new System.Drawing.Size(835, 684);
            this.tableLayoutPanel_BackGround.TabIndex = 1;
            // 
            // panel_DataGridView
            // 
            this.panel_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.panel_DataGridView.Name = "panel_DataGridView";
            this.panel_DataGridView.Size = new System.Drawing.Size(829, 575);
            this.panel_DataGridView.TabIndex = 0;
            // 
            // panel_Functions
            // 
            this.panel_Functions.Controls.Add(this.checkBox_LoadCsv);
            this.panel_Functions.Controls.Add(this.checkBox_LoadExcel);
            this.panel_Functions.Controls.Add(this.buttonCreateFiles);
            this.panel_Functions.Controls.Add(this.buttonImport);
            this.panel_Functions.Controls.Add(this.textBox_ImportFilePath);
            this.panel_Functions.Controls.Add(this.button_SelectFile);
            this.panel_Functions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Functions.Location = new System.Drawing.Point(3, 584);
            this.panel_Functions.Name = "panel_Functions";
            this.panel_Functions.Size = new System.Drawing.Size(829, 97);
            this.panel_Functions.TabIndex = 1;
            // 
            // checkBox_LoadCsv
            // 
            this.checkBox_LoadCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_LoadCsv.AutoSize = true;
            this.checkBox_LoadCsv.Location = new System.Drawing.Point(11, 18);
            this.checkBox_LoadCsv.Name = "checkBox_LoadCsv";
            this.checkBox_LoadCsv.Size = new System.Drawing.Size(46, 17);
            this.checkBox_LoadCsv.TabIndex = 21;
            this.checkBox_LoadCsv.Text = ".csv";
            this.checkBox_LoadCsv.UseVisualStyleBackColor = true;
            this.checkBox_LoadCsv.CheckedChanged += new System.EventHandler(this.checkBox_LoadCsv_CheckedChanged);
            // 
            // checkBox_LoadExcel
            // 
            this.checkBox_LoadExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_LoadExcel.AutoSize = true;
            this.checkBox_LoadExcel.Location = new System.Drawing.Point(63, 18);
            this.checkBox_LoadExcel.Name = "checkBox_LoadExcel";
            this.checkBox_LoadExcel.Size = new System.Drawing.Size(46, 17);
            this.checkBox_LoadExcel.TabIndex = 20;
            this.checkBox_LoadExcel.Text = ".xlsx";
            this.checkBox_LoadExcel.UseVisualStyleBackColor = true;
            this.checkBox_LoadExcel.CheckedChanged += new System.EventHandler(this.checkBox_LoadExcel_CheckedChanged);
            // 
            // buttonCreateFiles
            // 
            this.buttonCreateFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateFiles.Location = new System.Drawing.Point(671, 64);
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
            this.buttonImport.Location = new System.Drawing.Point(416, 64);
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
            this.textBox_ImportFilePath.Location = new System.Drawing.Point(7, 66);
            this.textBox_ImportFilePath.Name = "textBox_ImportFilePath";
            this.textBox_ImportFilePath.Size = new System.Drawing.Size(403, 20);
            this.textBox_ImportFilePath.TabIndex = 9;
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SelectFile.Location = new System.Drawing.Point(7, 38);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(150, 25);
            this.button_SelectFile.TabIndex = 8;
            this.button_SelectFile.Text = "Select IO Table";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // Form_IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 684);
            this.Controls.Add(this.tableLayoutPanel_BackGround);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_IO";
            this.Text = "Form_IO";
            this.Load += new System.EventHandler(this.Form_IO_Load);
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
    }
}