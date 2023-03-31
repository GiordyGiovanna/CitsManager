namespace GestoreCitazioni
{
    partial class FormInserimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbCit = new System.Windows.Forms.RichTextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.txtTit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAutori = new System.Windows.Forms.ComboBox();
            this.rtcComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci citazione";
            // 
            // rtbCit
            // 
            this.rtbCit.BackColor = System.Drawing.Color.White;
            this.rtbCit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCit.Location = new System.Drawing.Point(27, 89);
            this.rtbCit.Name = "rtbCit";
            this.rtbCit.Size = new System.Drawing.Size(723, 273);
            this.rtbCit.TabIndex = 1;
            this.rtbCit.Text = "";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(610, 384);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(150, 46);
            this.btnInserisci.TabIndex = 2;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // txtTit
            // 
            this.txtTit.Location = new System.Drawing.Point(477, 35);
            this.txtTit.Name = "txtTit";
            this.txtTit.Size = new System.Drawing.Size(200, 39);
            this.txtTit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titolo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autore:";
            // 
            // cmbAutori
            // 
            this.cmbAutori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAutori.BackColor = System.Drawing.Color.White;
            this.cmbAutori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAutori.ForeColor = System.Drawing.Color.Black;
            this.cmbAutori.FormattingEnabled = true;
            this.cmbAutori.Location = new System.Drawing.Point(134, 395);
            this.cmbAutori.Name = "cmbAutori";
            this.cmbAutori.Size = new System.Drawing.Size(242, 40);
            this.cmbAutori.TabIndex = 6;
            // 
            // rtcComment
            // 
            this.rtcComment.BackColor = System.Drawing.Color.White;
            this.rtcComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtcComment.Location = new System.Drawing.Point(27, 499);
            this.rtcComment.Name = "rtcComment";
            this.rtcComment.Size = new System.Drawing.Size(723, 273);
            this.rtcComment.TabIndex = 7;
            this.rtcComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Commento";
            // 
            // FormInserimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 899);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtcComment);
            this.Controls.Add(this.cmbAutori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTit);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.rtbCit);
            this.Controls.Add(this.label1);
            this.Name = "FormInserimento";
            this.Text = "FormInserimento";
            this.Load += new System.EventHandler(this.FormInserimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox rtbCit;
        private Button btnInserisci;
        private TextBox txtTit;
        private Label label2;
        private Label label3;
        private ComboBox cmbAutori;
        private RichTextBox rtcComment;
        private Label label4;
    }
}