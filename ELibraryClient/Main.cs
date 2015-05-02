using ELibraryServer;
using System;
using System.Data;
using System.Windows.Forms;

namespace ELibraryClient
{
    public partial class Main : Form
    {
        private Books formBooks;
        private static DataSet dsELibrary;

        public Main()
        {
            InitializeComponent();
            booksToolStripMenuItem.Enabled = false;
            AttachEvents();
        }

        public static DataSet DsELibrary
        {
            get
            {
                return dsELibrary;
            }
            set
            {
                dsELibrary = value;
            }
        }

        private void AttachEvents()
        {
            exitToolStripMenuItem.Click += new EventHandler(this.ExitToolStripMenuItem_Click);
            connectServerToolStripMenuItem.Click += new EventHandler(this.ConnectServerToolStripMenuItem_Click);
            showBooksToolStripMenuItem.Click += new EventHandler(this.Books_Click);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.formBooks = new Books();
            this.formBooks.MdiParent = this;
            this.formBooks.WindowState = FormWindowState.Maximized;
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // The user wants to exit the application. Close everything down.
            Application.Exit();
        }

        private void ConnectServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dsELibrary == null)
            {
                DataAccessLibrary dal = new DataAccessLibrary();

                try
                {
                    dsELibrary = dal.GetELibraryDataSet();
                    MessageBox.Show("Server connected");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error connecting to eLibrary Server", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                booksToolStripMenuItem.Enabled = true;
            }
        }

        private void Books_Click(object sender, EventArgs e)
        {
            if (this.formBooks == null || this.formBooks.IsDisposed)
            {
                this.formBooks = new Books();
                this.formBooks.MdiParent = this;
            }

            this.formBooks.BringToFront();
            this.formBooks.WindowState = FormWindowState.Maximized;
            this.formBooks.Show();
        }
    }

}
