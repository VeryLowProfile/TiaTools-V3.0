
namespace TiaTools_V3._0.Forms
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_Messages = new System.Windows.Forms.Button();
            this.button_StateMachines = new System.Windows.Forms.Button();
            this.button_IO = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.button_ReportManager = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.AutoScroll = true;
            this.panel_Menu.BackColor = System.Drawing.Color.Silver;
            this.panel_Menu.Controls.Add(this.button_ReportManager);
            this.panel_Menu.Controls.Add(this.button_Messages);
            this.panel_Menu.Controls.Add(this.button_StateMachines);
            this.panel_Menu.Controls.Add(this.button_IO);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Menu.Location = new System.Drawing.Point(3, 3);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(145, 723);
            this.panel_Menu.TabIndex = 2;
            // 
            // button_Messages
            // 
            this.button_Messages.Location = new System.Drawing.Point(12, 45);
            this.button_Messages.Name = "button_Messages";
            this.button_Messages.Size = new System.Drawing.Size(117, 23);
            this.button_Messages.TabIndex = 1;
            this.button_Messages.Text = "Messages";
            this.button_Messages.UseVisualStyleBackColor = true;
            this.button_Messages.Click += new System.EventHandler(this.button_Messages_Click);
            // 
            // button_StateMachines
            // 
            this.button_StateMachines.Location = new System.Drawing.Point(12, 74);
            this.button_StateMachines.Name = "button_StateMachines";
            this.button_StateMachines.Size = new System.Drawing.Size(117, 23);
            this.button_StateMachines.TabIndex = 2;
            this.button_StateMachines.Text = "State Machines";
            this.button_StateMachines.UseVisualStyleBackColor = true;
            this.button_StateMachines.Click += new System.EventHandler(this.button_StateMachines_Click);
            // 
            // button_IO
            // 
            this.button_IO.Location = new System.Drawing.Point(12, 16);
            this.button_IO.Name = "button_IO";
            this.button_IO.Size = new System.Drawing.Size(117, 23);
            this.button_IO.TabIndex = 0;
            this.button_IO.Text = "I/O";
            this.button_IO.UseVisualStyleBackColor = true;
            this.button_IO.Click += new System.EventHandler(this.button_IO_Click);
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 2;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Menu, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.panel_ChildForm, 1, 0);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1008, 729);
            this.tableLayoutPanel_Main.TabIndex = 3;
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(154, 3);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(851, 723);
            this.panel_ChildForm.TabIndex = 3;
            // 
            // button_ReportManager
            // 
            this.button_ReportManager.Location = new System.Drawing.Point(12, 103);
            this.button_ReportManager.Name = "button_ReportManager";
            this.button_ReportManager.Size = new System.Drawing.Size(117, 23);
            this.button_ReportManager.TabIndex = 3;
            this.button_ReportManager.Text = "Report Manager";
            this.button_ReportManager.UseVisualStyleBackColor = true;
            this.button_ReportManager.Click += new System.EventHandler(this.button_ReportManager_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "TiaTools";
            this.panel_Menu.ResumeLayout(false);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_StateMachines;
        private System.Windows.Forms.Button button_Messages;
        private System.Windows.Forms.Button button_IO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.Panel panel_ChildForm;
        private System.Windows.Forms.Button button_ReportManager;
    }
}

