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
    public partial class viewYourBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        private string username;

        public viewYourBooks(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string x = comboBox1.Text;
            int y = (int)numericUpDown1.Value;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update books set feedback = "+y+"+(select feedback from books where " +
                "isbn='" +x+"') where isbn='"+x+"';";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved. Thank you for the help.");
            con.Close();
        }

        private void viewYourBooks_Load_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select isbn ISBN,title Title,author Author,gender Gender,feedback Feedback " +
                "from books where isbn in  (select distinct isbn from bills_detalies where id_bill in " +
                "(select id_bill from bills where type_of='bought' and id_reader= (select id_reader from " +
                "readers where username='"+username+"')));";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0) dataGridView1.DataSource = dt;
            else
            {
                MessageBox.Show("Nothing to show.");
                this.Hide();
            }


            cmd.CommandText = "select isbn from books where isbn in  (select distinct isbn from bills_detalies " +
                "where id_bill in (select id_bill from bills where type_of='bought' and id_reader= (select " +
                "id_reader from readers where username='"+username+"')));";
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da2.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "isbn";
        }
    }
}
