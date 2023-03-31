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
    public partial class FormInserimento : Form
    {
        public FormInserimento()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (checkInserimento())
            {
                Author a = (cmbAutori.SelectedItem as Author);
                Citazione newCitazione = new Citazione(txtTit.Text, rtbCit.Text, DateTime.Now, a.Id, rtcComment.Text);
                db_Cits.saveNewCit(newCitazione);
                this.Close();
            }
            else
            {
                MessageBox.Show("Parametro mancante", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkInserimento()
        {
            bool ret = true;
            ret = rtbCit.Text != "" || txtTit.Text != "" || cmbAutori.Text != "";
            return ret;
        }


        // Later
        private List<string> coolerCheckInserimento()
        {
            List<String> ret = new List<string>();
            foreach (Control con in this.Controls)
            {
                if (con.Text == String.Empty)
                {
                    ret.Add(con.Name);
                }
            }

            return ret;
        }

        private void FormInserimento_Load(object sender, EventArgs e)
        {
            foreach (Author a in db_Cits.getAllAuthorsData())
            {
                cmbAutori.Items.Add(a);
            }
        }
    }
}
