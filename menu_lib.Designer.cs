namespace Library
{
    partial class menu_lib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_lib));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInvoiceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLibrariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTheLibrariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAReturnBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTheBillsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.readersToolStripMenuItem,
            this.librariansToolStripMenuItem,
            this.logOutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
            resources.ApplyResources(this.booksToolStripMenuItem, "booksToolStripMenuItem");
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            resources.ApplyResources(this.addNewBookToolStripMenuItem, "addNewBookToolStripMenuItem");
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            resources.ApplyResources(this.editBookToolStripMenuItem, "editBookToolStripMenuItem");
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            resources.ApplyResources(this.viewBooksToolStripMenuItem, "viewBooksToolStripMenuItem");
            this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
            // 
            // readersToolStripMenuItem
            // 
            this.readersToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.readersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReadersToolStripMenuItem,
            this.viewOrdersToolStripMenuItem,
            this.editInvoiceDetailsToolStripMenuItem,
            this.viewAllInvoiceToolStripMenuItem});
            resources.ApplyResources(this.readersToolStripMenuItem, "readersToolStripMenuItem");
            this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
            this.readersToolStripMenuItem.Click += new System.EventHandler(this.readersToolStripMenuItem_Click);
            // 
            // viewReadersToolStripMenuItem
            // 
            this.viewReadersToolStripMenuItem.Name = "viewReadersToolStripMenuItem";
            resources.ApplyResources(this.viewReadersToolStripMenuItem, "viewReadersToolStripMenuItem");
            this.viewReadersToolStripMenuItem.Click += new System.EventHandler(this.viewReadersToolStripMenuItem_Click);
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            resources.ApplyResources(this.viewOrdersToolStripMenuItem, "viewOrdersToolStripMenuItem");
            this.viewOrdersToolStripMenuItem.Click += new System.EventHandler(this.viewOrdersToolStripMenuItem_Click);
            // 
            // editInvoiceDetailsToolStripMenuItem
            // 
            this.editInvoiceDetailsToolStripMenuItem.Name = "editInvoiceDetailsToolStripMenuItem";
            resources.ApplyResources(this.editInvoiceDetailsToolStripMenuItem, "editInvoiceDetailsToolStripMenuItem");
            this.editInvoiceDetailsToolStripMenuItem.Click += new System.EventHandler(this.editInvoiceDetailsToolStripMenuItem_Click);
            // 
            // viewAllInvoiceToolStripMenuItem
            // 
            this.viewAllInvoiceToolStripMenuItem.Name = "viewAllInvoiceToolStripMenuItem";
            resources.ApplyResources(this.viewAllInvoiceToolStripMenuItem, "viewAllInvoiceToolStripMenuItem");
            this.viewAllInvoiceToolStripMenuItem.Click += new System.EventHandler(this.viewAllInvoiceToolStripMenuItem_Click);
            // 
            // librariansToolStripMenuItem
            // 
            this.librariansToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.librariansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLibrariansToolStripMenuItem,
            this.addLibrarianToolStripMenuItem,
            this.deleteLibrarianToolStripMenuItem,
            this.editProfileToolStripMenuItem1});
            resources.ApplyResources(this.librariansToolStripMenuItem, "librariansToolStripMenuItem");
            this.librariansToolStripMenuItem.Name = "librariansToolStripMenuItem";
            // 
            // viewLibrariansToolStripMenuItem
            // 
            this.viewLibrariansToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.viewLibrariansToolStripMenuItem.Name = "viewLibrariansToolStripMenuItem";
            resources.ApplyResources(this.viewLibrariansToolStripMenuItem, "viewLibrariansToolStripMenuItem");
            this.viewLibrariansToolStripMenuItem.Click += new System.EventHandler(this.viewLibrariansToolStripMenuItem_Click);
            // 
            // addLibrarianToolStripMenuItem
            // 
            this.addLibrarianToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.addLibrarianToolStripMenuItem.Name = "addLibrarianToolStripMenuItem";
            resources.ApplyResources(this.addLibrarianToolStripMenuItem, "addLibrarianToolStripMenuItem");
            this.addLibrarianToolStripMenuItem.Click += new System.EventHandler(this.addLibrarianToolStripMenuItem_Click);
            // 
            // deleteLibrarianToolStripMenuItem
            // 
            this.deleteLibrarianToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.deleteLibrarianToolStripMenuItem.Name = "deleteLibrarianToolStripMenuItem";
            resources.ApplyResources(this.deleteLibrarianToolStripMenuItem, "deleteLibrarianToolStripMenuItem");
            this.deleteLibrarianToolStripMenuItem.Click += new System.EventHandler(this.deleteLibrarianToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem1
            // 
            this.editProfileToolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro;
            this.editProfileToolStripMenuItem1.Name = "editProfileToolStripMenuItem1";
            resources.ApplyResources(this.editProfileToolStripMenuItem1, "editProfileToolStripMenuItem1");
            this.editProfileToolStripMenuItem1.Click += new System.EventHandler(this.editProfileToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            // 
            // showTheLibrariansToolStripMenuItem
            // 
            this.showTheLibrariansToolStripMenuItem.Name = "showTheLibrariansToolStripMenuItem";
            resources.ApplyResources(this.showTheLibrariansToolStripMenuItem, "showTheLibrariansToolStripMenuItem");
            // 
            // makeAReturnBillToolStripMenuItem
            // 
            this.makeAReturnBillToolStripMenuItem.Name = "makeAReturnBillToolStripMenuItem";
            resources.ApplyResources(this.makeAReturnBillToolStripMenuItem, "makeAReturnBillToolStripMenuItem");
            // 
            // showAllTheBillsToolStripMenuItem1
            // 
            this.showAllTheBillsToolStripMenuItem1.Name = "showAllTheBillsToolStripMenuItem1";
            resources.ApplyResources(this.showAllTheBillsToolStripMenuItem1, "showAllTheBillsToolStripMenuItem1");
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Name = "label2";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.logOutToolStripMenuItem, "logOutToolStripMenuItem");
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menu_lib
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "menu_lib";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_lib_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem editBookToolStripMenuItem;
        private ToolStripMenuItem readersToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem librariansToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem showTheLibrariansToolStripMenuItem;
        private ToolStripMenuItem makeAReturnBillToolStripMenuItem;
        private ToolStripMenuItem showAllTheBillsToolStripMenuItem1;
        private ToolStripMenuItem viewLibrariansToolStripMenuItem;
        private ToolStripMenuItem addLibrarianToolStripMenuItem;
        private ToolStripMenuItem deleteLibrarianToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel;
        private StatusStrip statusStrip;
        private Label label1;
        private ToolStripMenuItem editProfileToolStripMenuItem1;
        private Label label2;
        private ToolStripMenuItem viewReadersToolStripMenuItem;
        private ToolStripMenuItem viewOrdersToolStripMenuItem;
        private ToolStripMenuItem editInvoiceDetailsToolStripMenuItem;
        private ToolStripMenuItem viewAllInvoiceToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}



