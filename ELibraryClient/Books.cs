using System;
using System.Windows.Forms;

namespace ELibraryClient
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
           // this.Load += new EventHandler(this.Books_Load);
            listBookTypes.SelectedIndexChanged += new EventHandler(this.ListBookTypes_SelectedIndexChanged);
            dataGridView1.RowHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            listBookTypes.DataSource = Main.DsELibrary.Tables["BookTypes"];
            listBookTypes.DisplayMember = "BookTypeName";
            listBookTypes.ValueMember = "BookTypeName";
            listBookTypes.SelectedIndex = -1;
        }

        private void Books_Load(object sender, EventArgs e)
        {
            listBookTypes.DataSource = Main.DsELibrary.Tables["BookTypes"];
            listBookTypes.DisplayMember = "BookTypeName";
            listBookTypes.ValueMember = "BookTypeName";
            listBookTypes.SelectedIndex = -1;
        }

        private void ListBookTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strValue = "";
            int number;
            if(listBookTypes.SelectedIndex>=0)
            {
                strValue = listBookTypes.SelectedIndex.ToString();
                number = listBookTypes.SelectedIndex + 1;
                listBookTypes.Text = "Selected category: " + strValue;
                Main.DsELibrary.Tables["Books"].DefaultView.RowFilter = "BookTypeID = " + number.ToString();
                dataGridView1.DataSource = Main.DsELibrary.Tables["Books"];
            }
            else if(listBookTypes.SelectedIndex == -1)
            {
                lblBookTypes.Text = "Selected category: " + strValue;
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedBook.SelectedISBN = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            SelectedBook selectedBookForm = new SelectedBook();
            selectedBookForm.ShowDialog();
        }
    }
}
