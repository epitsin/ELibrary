using System;
using System.Windows.Forms;

namespace ELibraryClient
{
    public partial class Main : Form
    {
        private Books formBooks;

        public Main()
        {
            InitializeComponent();
            exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
