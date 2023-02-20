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
    public partial class viewBills : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        public viewBills()
        {
            InitializeComponent();
        }

        private void viewBills_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct id_bill from bills;";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "id_bill";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = comboBox1.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_bill ID,bill_date Date,bill_price Price,type_of 'Type of bill'," +
                "username Username,name Name from bills a,rea_info b where a.id_reader=b.id_reader and " +
                "id_bill="+x+";";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt1;
                cmd.CommandText = "select a.isbn,title,author,gender,case when id_detalies%2=0 then 'Borrowed'" +
                    " when id_detalies%2=1 then 'Bought' end as Type from books a,bills_detalies b where " +
                    "a.isbn=b.isbn and id_bill="+x+" and  a.isbn in  (select isbn from bills_detalies where " +
                    "id_bill="+x+");";
                cmd.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                da2.Fill(dt2);
                if (dt2.Rows.Count > 0) dataGridView2.DataSource = dt2;
                else MessageBox.Show("We have issues. Try later.");
            }   
            else MessageBox.Show("We have issues. Try later.");
            con.Close();
        }
    }
}
