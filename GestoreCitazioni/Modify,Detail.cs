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
    public partial class Modify_Detail : Form
    {
        public Modify_Detail()
        {
            InitializeComponent();
        }

        Citazione citazione = new Citazione();
        public Modify_Detail(Citazione c) : this() 
        {
            citazione = c;
            rtbCit.Text = c.Cit;
            label1.Text = c.Titolo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            citazione.Cit = rtbCit.Text;
            citazione.save();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            citazione.delete();
            this.Close();
        }
    }
}
