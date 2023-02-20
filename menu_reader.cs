using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class menu_reader : Form
    {
        private int childFormNumber = 0;
        private string username;
        private bool toReturn;

        public menu_reader(string username)
        {
            InitializeComponent();
            this.username = username;
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

        private void viewOurBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewYourBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editProfile ep = new editProfile(username);
            ep.Show();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBooks vb = new viewBooks(false);
            vb.Show();
        }

        private void searchLibrariansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewLib vl = new viewLib();
            vl.Show();
        }

        private void viewYourBooksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewYourBooks vb = new viewYourBooks(username);
            vb.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toReturn) MessageBox.Show("We cannot delete the account, you have books to return. If there is an error, contact an administrator.");
            else
            {
                DialogResult x = MessageBox.Show("Are you sure you want to delete the account?", "Delete account", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
                    string upd = "update users set name='-', mail='-',phone='-' where username='" + username + "';";
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = upd;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your account is deleted.");
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
            }
            
        }

        private void menu_reader_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select title Ttile,author Author,datediff(day,convert(date,getdate())," +
                "date_for_return) 'Days left',date_for_return 'Date for return' from books a, (select isbn," +
                "date_for_return from borrowings where is_returned='false' and id_bill  in (select id_bill " +
                "from bills where send_to='true' and id_reader = (select id_reader from readers where  " +
                "username='"+username+"'))) b where a.isbn=b.isbn order by 'Days left';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                toReturn = true;
            }
            else
            {
                toReturn = false;
                label1.Hide();
            }
            con.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }
    }
}
