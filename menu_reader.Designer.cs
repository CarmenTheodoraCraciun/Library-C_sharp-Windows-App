namespace Library
{
    partial class menu_reader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_reader));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewYourBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewYourBooksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buyBorrowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewYourProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOurBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLibrariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewYourBooksToolStripMenuItem,
            this.viewOurBooksToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1208, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // viewYourBooksToolStripMenuItem
            // 
            this.viewYourBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewYourBooksToolStripMenuItem1,
            this.buyBorrowToolStripMenuItem1,
            this.viewYourProfileToolStripMenuItem,
            this.editProfileToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.viewYourBooksToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewYourBooksToolStripMenuItem.Name = "viewYourBooksToolStripMenuItem";
            this.viewYourBooksToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.viewYourBooksToolStripMenuItem.Text = "About you";
            this.viewYourBooksToolStripMenuItem.Click += new System.EventHandler(this.viewYourBooksToolStripMenuItem_Click);
            // 
            // viewYourBooksToolStripMenuItem1
            // 
            this.viewYourBooksToolStripMenuItem1.Name = "viewYourBooksToolStripMenuItem1";
            this.viewYourBooksToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.viewYourBooksToolStripMenuItem1.Text = "View your books";
            this.viewYourBooksToolStripMenuItem1.Click += new System.EventHandler(this.viewYourBooksToolStripMenuItem1_Click);
            // 
            // buyBorrowToolStripMenuItem1
            // 
            this.buyBorrowToolStripMenuItem1.Name = "buyBorrowToolStripMenuItem1";
            this.buyBorrowToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.buyBorrowToolStripMenuItem1.Text = "Buy/ Borrow";
            // 
            // viewYourProfileToolStripMenuItem
            // 
            this.viewYourProfileToolStripMenuItem.Name = "viewYourProfileToolStripMenuItem";
            this.viewYourProfileToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.viewYourProfileToolStripMenuItem.Text = "View profile";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.deleteAccountToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.deleteAccountToolStripMenuItem.Text = "Delete account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // viewOurBooksToolStripMenuItem
            // 
            this.viewOurBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBookToolStripMenuItem,
            this.searchLibrariansToolStripMenuItem});
            this.viewOurBooksToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewOurBooksToolStripMenuItem.Name = "viewOurBooksToolStripMenuItem";
            this.viewOurBooksToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.viewOurBooksToolStripMenuItem.Text = "About us";
            this.viewOurBooksToolStripMenuItem.Click += new System.EventHandler(this.viewOurBooksToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.searchBookToolStripMenuItem.Text = "Search book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // searchLibrariansToolStripMenuItem
            // 
            this.searchLibrariansToolStripMenuItem.Name = "searchLibrariansToolStripMenuItem";
            this.searchLibrariansToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.searchLibrariansToolStripMenuItem.Text = "Search librarians";
            this.searchLibrariansToolStripMenuItem.Click += new System.EventHandler(this.searchLibrariansToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1208, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 139);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "The books you have to return.";
            // 
            // menu_reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "menu_reader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_reader_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem viewOurBooksToolStripMenuItem;
        private ToolStripMenuItem viewYourBooksToolStripMenuItem;
        private ToolStripMenuItem editProfileToolStripMenuItem;
        private ToolStripMenuItem viewYourBooksToolStripMenuItem1;
        private ToolStripMenuItem buyBorrowToolStripMenuItem1;
        private ToolStripMenuItem viewYourProfileToolStripMenuItem;
        private ToolStripMenuItem searchBookToolStripMenuItem;
        private ToolStripMenuItem searchLibrariansToolStripMenuItem;
        private ToolStripMenuItem deleteAccountToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}



