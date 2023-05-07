using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

                Author ?a = cmbAutori?.SelectedItem as Author;
                if (a == null)
                {
                    a = db_Cits.getAuthorInLike(cmbAutori.Text);
                    if (a == null)
                    {
                        DialogResult dg = MessageBox.Show("Autore non trovato, vuoi aggiungere un nuovo autore?", "Autore non esistente",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            a = startProcedureToAddNewAuthor(cmbAutori.Text);
                            cmbAutori.Items.Add(a);
                        }
                    }
                }
                else
                {
                    Citazione newCitazione = new Citazione(txtTit.Text, rtbCit.Text, DateTime.Now, cmbTypo.SelectedItem.ToString(), a.Id, rtcComment.Text);
                    db_Cits.saveNewCit(newCitazione);
                    this.Close();
                    return;
                }
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

        private Author startProcedureToAddNewAuthor(string textNewAuthor)
        {
            Author newAuth;
            //Apro la nuova form con dei dati già popolati
            InserimentoAutore a = new InserimentoAutore(textNewAuthor);
            DialogResult dga;
            do
            {
                dga = a.ShowDialog();
                newAuth =  a.newOne;
            }
            while (dga != DialogResult.Yes) ;
            return newAuth;
        }

        private void FormInserimento_Load(object sender, EventArgs e)
        {
            List<Author> list = db_Cits.getAllAuthorsData();
            foreach (Author a in list)
            {
                cmbAutori.Items.Add(a);
            }
        }
    }
}
