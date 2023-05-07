namespace GestoreCitazioni
{
    partial class Modify_Detail
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
            this.rtbCit = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbCit
            // 
            this.rtbCit.BackColor = System.Drawing.SystemColors.Control;
            this.rtbCit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbCit.Location = new System.Drawing.Point(13, 60);
            this.rtbCit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rtbCit.Name = "rtbCit";
            this.rtbCit.Size = new System.Drawing.Size(933, 439);
            this.rtbCit.TabIndex = 0;
            this.rtbCit.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1057, 111);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1057, 60);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Elimina";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Modify_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbCit);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Modify_Detail";
            this.Text = "Modify_Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbCit;
        private Button btnSave;
        private Button btnDelete;
        private Label label1;
    }
}