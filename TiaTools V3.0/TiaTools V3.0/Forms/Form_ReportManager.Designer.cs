
namespace TiaTools_V3._0.Forms
{
    partial class Form_ReportManager
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Functions = new System.Windows.Forms.Panel();
            this.buttonCreateFiles = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.textBox_ImportFilePath = new System.Windows.Forms.TextBox();
            this.button_SelectFile = new System.Windows.Forms.Button();
            this.panel_DataGridView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_Functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_Functions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_DataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(851, 723);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_Functions
            // 
            this.panel_Functions.AutoScroll = true;
            this.panel_Functions.Controls.Add(this.buttonCreateFiles);
            this.panel_Functions.Controls.Add(this.buttonImport);
            this.panel_Functions.Controls.Add(this.textBox_ImportFilePath);
            this.panel_Functions.Controls.Add(this.button_SelectFile);
            this.panel_Functions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Functions.Location = new System.Drawing.Point(3, 617);
            this.panel_Functions.Name = "panel_Functions";
            this.panel_Functions.Size = new System.Drawing.Size(845, 103);
            this.panel_Functions.TabIndex = 0;
            // 
            // buttonCreateFiles
            // 
            this.buttonCreateFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateFiles.Location = new System.Drawing.Point(687, 71);
            this.buttonCreateFiles.Name = "buttonCreateFiles";
            this.buttonCreateFiles.Size = new System.Drawing.Size(150, 25);
            this.buttonCreateFiles.TabIndex = 18;
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
            this.buttonImport.TabIndex = 17;
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
            this.textBox_ImportFilePath.TabIndex = 16;
            // 
            // button_SelectFile
            // 
            this.button_SelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SelectFile.Location = new System.Drawing.Point(7, 44);
            this.button_SelectFile.Name = "button_SelectFile";
            this.button_SelectFile.Size = new System.Drawing.Size(150, 25);
            this.button_SelectFile.TabIndex = 15;
            this.button_SelectFile.Text = "Select Report Man. Table";
            this.button_SelectFile.UseVisualStyleBackColor = true;
            this.button_SelectFile.Click += new System.EventHandler(this.button_SelectFile_Click);
            // 
            // panel_DataGridView
            // 
            this.panel_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.panel_DataGridView.Name = "panel_DataGridView";
            this.panel_DataGridView.Size = new System.Drawing.Size(845, 608);
            this.panel_DataGridView.TabIndex = 1;
            // 
            // Form_ReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 723);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ReportManager";
            this.Text = "Form_ReportManager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_Functions.ResumeLayout(false);
            this.panel_Functions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_Functions;
        private System.Windows.Forms.Panel panel_DataGridView;
        private System.Windows.Forms.Button buttonCreateFiles;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.TextBox textBox_ImportFilePath;
        private System.Windows.Forms.Button button_SelectFile;
    }
}