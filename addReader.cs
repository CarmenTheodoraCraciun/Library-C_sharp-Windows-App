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
using System.Text.RegularExpressions;

namespace Library
{
    public partial class addReader : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        public addReader()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (checks())
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string x = "insert into users(username,name,password,mail,phone,isLib) values ('" +
                    textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text
                    + "','" + textBox5.Text + "','false');\ninsert into readers(id_reader,username)" +
                    " values (next value for reaid,'" + textBox1.Text + "');";
                cmd.CommandText = x;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Now you are ours. Return to the login page.");
                Login l = new Login();
                l.Show();
                this.Hide();
                con.Close();
            }
        }
        private bool checks()
        {
            return checkEmpty() && uniqueUsername(textBox1.Text) &&
                checkMail(textBox4.Text) && checkPhone(textBox5.Text);
        }
        private bool checkPhone(string s)
        {
            for (int i = 0; i < s.Length; ++i)
                if (!(('0' <= s[i] && s[i] <= '9') || s[i] == '+' || s[i] == '-'))
                {
                    MessageBox.Show("Incorrect phone.");
                    return false;
                }
            return true;
        }
        private bool checkMail(string s)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(s);
            if (match.Success) return true;
            MessageBox.Show("Incorrect mail.");
            return false;
        }
        private bool uniqueUsername(string s)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where username='" + s + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The username already exist.");
                return false;
            }
            return true;
        }
        private bool checkEmpty()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("All fields are mandatory.");
                return false;
            }
            return true;
        }
    }
}
