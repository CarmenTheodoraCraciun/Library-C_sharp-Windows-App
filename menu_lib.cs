using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class menu_lib : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        private int childFormNumber = 0;
        private string username;
        /*public menu_lib()
        {
            InitializeComponent();
        }
        */
        public menu_lib(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBook ab = new addBook();
            ab.Show();
        }
        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editBooks eb = new editBooks();
            eb.Show();
        }
        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBooks vb = new viewBooks(true);
            vb.Show();
        }
        /*private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from lib_info where username='" + username + "' and isAdmin='true';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count == 1)
            {
                addLib ad = new addLib();
                ad.Show();
            }
            else MessageBox.Show("You don't have permission.");
        }
        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void showAllTheBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void addReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addReader ar = new addReader();
            ar.Show();
        }
        /*private void showTheLibrariansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewLib vl = new viewLib();
            vl.Show();
        }*/
        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void viewLibrariansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewLib vl = new viewLib();
            vl.Show();
        }
        private void addLibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from lib_info where username='" + username + "' and isAdmin='true';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count == 1)
            {
                addLib al = new addLib();
                al.Show();
            }
            else MessageBox.Show("You don't have permission.");
        }
        private void deleteLibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from lib_info where username='" + username + "' and isAdmin='true';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count == 1)
            {
                delLib dl = new delLib();
                dl.Show();
            }
            else MessageBox.Show("You don't have permission.");
        }

        private void menu_lib_Load(object sender, EventArgs e)
        {
            /*TODO 
             * SqlCommand cmd = new SqlCommand("select name from lib_info where username='" + username + "';",con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            label2.Text = "Welcome " + reader["name"].ToString();
            con.Close();*/
        }

        private void editProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editProfile ep = new editProfile(username);
            ep.Show();
        }

        private void viewReadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewReaders vr = new viewReaders();
            vr.Show();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editInvoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBills vb = new viewBills();
            vb.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
    }
}
