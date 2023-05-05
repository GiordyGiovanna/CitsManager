namespace GestoreCitazioni
{
    public partial class Gestore : Form
    {
        List<Citazione> list = new List<Citazione>();
        public Gestore()
        {
            InitializeComponent();
        }
        /// <summary 1.0>
        /// TODO:
        /// 1 - Make the list look better - It looks OK
        /// 2 - finish the insert form - DONE
        /// 3 - make Modify form interactable - DONE
        /// 4 - Optimizations - DONE
        /// 5 - Insert - DONE
        /// 6 - DELETE - DONE
        /// 7 - Deploy 1.0 In a new GitRepository
        /// </summary>
        /// 
        ///
        /// <summary 2.0>
        /// 1 - CHANGE GRAPHICS --> TBD
        /// 2 - Make Date --> lastModify --> DONE
        /// 3 - Users (?)
        /// 4 - add Typo (dialogo/citazione/ecc) -- DONE
        /// 5 - Add the Author in a good way 
        /// 6 - Complite coolerCheck
        /// 7 - addComment --> DONE (change graphics) --> TODO
        /// 8 - Export csv File |
        ///                     |--> Added Buttons
        /// 9 - Import csv File |
        /// 10- Gestire apostrofi
        /// soon
        /// 


        

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            FormInserimento f = new FormInserimento();
            f.ShowDialog();
            refresh();
        }

        private void refresh()
        {
            dgvCit.Dispose();
            dgvCit = new DataGridView();
            dgvCit.AllowUserToAddRows = false;
            dgvCit.AllowUserToDeleteRows = false;
            dgvCit.AllowUserToOrderColumns = true;
            dgvCit.AllowUserToResizeColumns = false;
            dgvCit.AllowUserToResizeRows = false;
            dgvCit.BackgroundColor = Color.White;
            dgvCit.BorderStyle = BorderStyle.None;
            dgvCit.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCit.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCit.GridColor = Color.White;
            dgvCit.Location = new Point(12, 12);
            dgvCit.Margin = new Padding(0);
            dgvCit.MultiSelect = false;
            dgvCit.Name = "dgvCit";
            dgvCit.ReadOnly = true;
            dgvCit.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCit.RowHeadersVisible = false;
            dgvCit.RowHeadersWidth = 82;
            dgvCit.RowTemplate.Height = 41;
            dgvCit.Size = new Size(1440, 620);
            dgvCit.TabIndex = 1;
            dgvCit.CellContentClick += new DataGridViewCellEventHandler(dgvCit_CellContentClick);
            Controls.Add(dgvCit);
            list = db_Cits.Allcits;
            dgvCit.DataSource = list;
            for (int i = 0; i < dgvCit.ColumnCount; i++)
            {
                if(i != 1) dgvCit.AutoResizeColumn(i);
            }
            dgvCit.Refresh();
        }

        private void dgvCit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Open another Form to see and modify the cit.
            // Coming better soon
            if(e.RowIndex > -1)
            {
                Modify_Detail mod = new Modify_Detail(list[e.RowIndex]);
                mod.ShowDialog();
                refresh();
            }
        }
    }
}