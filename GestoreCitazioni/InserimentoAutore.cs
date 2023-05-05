using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestoreCitazioni
{
    public partial class InserimentoAutore : Form
    {
        public Author newOne;
        public InserimentoAutore()
        {
            InitializeComponent();
        }

        public InserimentoAutore(string nomeDefault)
        {
            InitializeComponent();
            txtNome.Text = nomeDefault;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Author a;
            //TBD Controllo popolazione valori
            if( txtCognome.Text == "" ||
                txtComesFrom.Text == "" ||
                txtNome.Text == "")
            {
                MessageBox.Show("Dati mancanti");// da migliorare
            }
            else
            {
                if (numericUpDown1.Value != 0)
                {
                    a = db_Cits.getAuthorsData(db_Cits.addNewAuthor(txtNome.Text, txtCognome.Text, txtComesFrom.Text, numericUpDown1.Value.ToString()));
                }
                else
                {
                    a = db_Cits.getAuthorsData(db_Cits.addNewAuthor(txtNome.Text, txtCognome.Text, txtComesFrom.Text));
                }
                newOne = a;
            }    
            this.Close();
        }
    }
}
