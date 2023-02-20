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
    public partial class viewNewBills : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        string id;
        public viewNewBills()
        {
            InitializeComponent();
        }

        private void viewNewBills_Load(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_bill from bills where is_done='false';";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cmd.ExecuteNonQuery();
            
            if (ds1.Tables[0].Rows.Count > 0)
            {
                comboBox1.DataSource = ds1.Tables[0];
                comboBox1.DisplayMember = "id_bill";
                button1.Show();
            }
            else
            {
                label3.Text = "There are no packages to make.";
            }


            cmd.CommandText = "select id_bill from bills where send_to='false' and is_done='true';";
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            cmd.ExecuteNonQuery();

            if (ds2.Tables[0].Rows.Count > 0)
            {
                comboBox2.DataSource = ds2.Tables[0];
                comboBox2.DisplayMember = "id_bill";
                button3.Show();
            }
            else
            {
                label4.Text = "There are no packages to send.";
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = comboBox1.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select isbn ISBN,title Title,author Author,gender Gender from books where isbn " +
                "in (select isbn from bills_detalies where id_bill="+id+") order by isbn;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                button2.Show();
            }
            else MessageBox.Show("We have issues. Try later.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update bills set is_done='true' where id_bill="+id+";";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save.");

            cmd.CommandText = "select id_bill from bills where send_to='false' and is_done='true';";
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            cmd.ExecuteNonQuery();

            if (ds2.Tables[0].Rows.Count > 0)
            {
                comboBox2.DataSource = ds2.Tables[0];
                comboBox2.DisplayMember = "id_bill";
            }
            else
            {
                label4.Text = "There are no packages to send.";
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update bills set send_to='true' where id_bill="+comboBox2.Text+";";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save.");
            
            cmd.CommandText = "select id_bill from bills where send_to='false' and is_done='true';";
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            cmd.ExecuteNonQuery();

            if (ds2.Tables[0].Rows.Count > 0)
            {
                comboBox2.DataSource = ds2.Tables[0];
                comboBox2.DisplayMember = "id_bill";
            }
            else
            {
                label4.Text = "There are no packages to send.";
            }
            con.Close();
        }
    }
}
