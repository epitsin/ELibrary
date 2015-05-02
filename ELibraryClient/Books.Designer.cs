namespace ELibraryClient
{
    partial class Books
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblBookTypes = new System.Windows.Forms.Label();
            this.listBookTypes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(155, 22);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(68, 13);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "List of Books";
            // 
            // lblBookTypes
            // 
            this.lblBookTypes.AutoSize = true;
            this.lblBookTypes.Enabled = false;
            this.lblBookTypes.Location = new System.Drawing.Point(19, 22);
            this.lblBookTypes.Name = "lblBookTypes";
            this.lblBookTypes.Size = new System.Drawing.Size(91, 13);
            this.lblBookTypes.TabIndex = 2;
            this.lblBookTypes.Text = "Select a Category";
            // 
            // listBookTypes
            // 
            this.listBookTypes.FormattingEnabled = true;
            this.listBookTypes.Location = new System.Drawing.Point(22, 38);
            this.listBookTypes.Name = "listBookTypes";
            this.listBookTypes.Size = new System.Drawing.Size(130, 251);
            this.listBookTypes.TabIndex = 3;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 312);
            this.Controls.Add(this.listBookTypes);
            this.Controls.Add(this.lblBookTypes);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBooks";
            this.Text = "List of Books";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblBookTypes;
        private System.Windows.Forms.ListBox listBookTypes;
    }
}

