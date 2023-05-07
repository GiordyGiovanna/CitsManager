namespace GestoreCitazioni
{
    partial class Gestore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestore));
            this.BtnInserisci = new System.Windows.Forms.Button();
            this.dgvCit = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Export = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInserisci
            // 
            this.BtnInserisci.Location = new System.Drawing.Point(1459, 50);
            this.BtnInserisci.Name = "BtnInserisci";
            this.BtnInserisci.Size = new System.Drawing.Size(150, 50);
            this.BtnInserisci.TabIndex = 0;
            this.BtnInserisci.Text = "Inserisci";
            this.BtnInserisci.UseVisualStyleBackColor = true;
            this.BtnInserisci.Click += new System.EventHandler(this.BtnInserisci_Click);
            // 
            // dgvCit
            // 
            this.dgvCit.AllowUserToAddRows = false;
            this.dgvCit.AllowUserToDeleteRows = false;
            this.dgvCit.AllowUserToOrderColumns = true;
            this.dgvCit.AllowUserToResizeColumns = false;
            this.dgvCit.AllowUserToResizeRows = false;
            this.dgvCit.BackgroundColor = System.Drawing.Color.White;
            this.dgvCit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCit.GridColor = System.Drawing.Color.White;
            this.dgvCit.Location = new System.Drawing.Point(12, 50);
            this.dgvCit.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCit.MultiSelect = false;
            this.dgvCit.Name = "dgvCit";
            this.dgvCit.ReadOnly = true;
            this.dgvCit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCit.RowHeadersVisible = false;
            this.dgvCit.RowHeadersWidth = 82;
            this.dgvCit.RowTemplate.Height = 41;
            this.dgvCit.Size = new System.Drawing.Size(1440, 620);
            this.dgvCit.TabIndex = 1;
            this.dgvCit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCit_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1621, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Export
            // 
            this.Export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(89, 38);
            this.Export.Text = "Tools";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // Gestore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1621, 739);
            this.Controls.Add(this.dgvCit);
            this.Controls.Add(this.BtnInserisci);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestore";
            this.Text = "Gestore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnInserisci;
        private DataGridView dgvCit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Export;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
    }
}