using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class editProfile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        private string username;

        public editProfile()
        {
            InitializeComponent();
        }

        public editProfile(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void editProfile_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string upd = "update users set ";
            int count = 0;
            bool msg = true;
            if (!string.IsNullOrEmpty(textBox2.Text) && msg)
            {
                ++count;
                upd += "password= '" + textBox2.Text + "'";
            }
            if (!string.IsNullOrEmpty(textBox3.Text) && msg)
            {
                if (count > 0) upd += ", ";
                ++count;
                if (checkMail(textBox3.Text)) upd += "mail= '" + textBox3.Text + "'";
                else msg = false;
            }
            if (!string.IsNullOrEmpty(textBox4.Text) && msg)
            {
                if (count > 0) upd += ", ";
                ++count;
                if (checkMail(textBox4.Text)) upd += "phone= '" + textBox4.Text + "'";
                else msg = false;
            }
            if(msg)
            {
                if (count > 0)
                {
                    upd += " where username='" + this.username + "';";
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = upd;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated.");
                    con.Close();
                }
                else MessageBox.Show("At least one field must be filled.");
            }
           
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
    }
}
