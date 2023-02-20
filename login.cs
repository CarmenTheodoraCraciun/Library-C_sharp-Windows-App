using System;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        int count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            addReader cr = new addReader();
            cr.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users_login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "' and isLib='true'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (Convert.ToInt32(dt.Rows.Count.ToString()) == 0)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users_login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (Convert.ToInt32(dt.Rows.Count.ToString()) == 0)
                    MessageBox.Show("Incorrect username or password.");
                else
                {
                    this.Hide();
                    menu_reader menu = new menu_reader(textBox1.Text);
                    menu.Show();
                }
            }
            else
            {
                this.Hide();
                menu_lib menu = new menu_lib(textBox1.Text);
                menu.Show();
            }
        }
    }
}