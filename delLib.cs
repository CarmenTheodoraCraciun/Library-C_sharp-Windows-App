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
    public partial class delLib : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        string username;
        public delLib()
        {
            InitializeComponent();
        }
        private void delLib_Load(object sender, EventArgs e)
        {
            button2.Hide();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username,name Name,mail Mail,phone Phone from lib_info;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                dataGridView1.DataSource = dt;
            else MessageBox.Show("This is empty");
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string s = "delete from librarians where username='" + username
                + "';\ndelete users where username = '" + username + "'; ";
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            MessageBox.Show(textBox2.Text + " deleted.");
            con.Close();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string s;
            if (string.IsNullOrEmpty(textBox2.Text))
                s= "select username,name Name,mail Mail,phone Phone from lib_info;";
            else
                s = "select username,name Name,mail Mail,phone Phone from lib_info " +
                    "where username='" + textBox2.Text + "';";
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 1)
                {
                    username = textBox2.Text;
                    button2.Show();
                }
            }
            else MessageBox.Show(textBox2.Text + " not found.");
            con.Close();
        }
    }
}
