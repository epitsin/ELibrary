using ELibraryServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELibraryClient
{
    public partial class SelectedBook : Form
    {
        public SelectedBook()
        {
            InitializeComponent();
            DataAccessLibrary dataAccessLibrary = new DataAccessLibrary();
            DataTable dataTable = dataAccessLibrary.GetBookByISBN(SelectedISBN);
            DataRow row = dataTable.Rows[0];
            this.txtISBN.Text = SelectedISBN;
            txtTitle.Text = row["Title"].ToString();
            txtAuthors.Text = row["Authors"].ToString();
            txtDescription.Text = row["Description"].ToString();
        }

        public static string SelectedISBN { get; set; }

        private void SelectedBook_Load(object sender, EventArgs e)
        {
            //DataAccessLibrary dataAccessLibrary = new DataAccessLibrary();
            //DataTable dataTable = dataAccessLibrary.GetBookByISBN(SelectedISBN);
            //DataRow row = dataTable.Rows[0];
            //this.txtISBN.Text = SelectedISBN;
            //txtTitle.Text = row["Title"].ToString();
            //txtAuthors.Text = row["Authors"].ToString();
            //txtDescription.Text = row["Description"].ToString();
        }

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblAuthors_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
