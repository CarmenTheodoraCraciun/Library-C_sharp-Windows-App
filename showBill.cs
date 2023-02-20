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
    public partial class showBill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        public showBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from borrowings where id_bill = 50;\ndelete from boughts where id_bill = 50;\ndelete from bills where id_bill = 50; ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Bill deleted.");
            this.Hide();
        }

        private void showBill_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name,bill_date,bill_price,isbn,title,author from rea_info x," +
                "(select bill_date, bill_price, isbn, title, author, id_reader from bills x,(select id_bill," +
                " x.isbn, title, author from books x,(select distinct isbn, b1.id_bill from boughts b1, " +
                "bills b2 where b1.id_bill = b2.id_bill) y where x.isbn = y.isbn) y where x.id_bill = " +
                "y.id_bill and x.id_bill = 50) y where x.id_reader = y.id_reader; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmd.CommandText = "select name, bill_date,bill_price, isbn, title, author from rea_info x, (select bill_date, bill_price, isbn,title, author, id_reader, is_returned from bills x, (select id_bill, x.isbn, title,author, is_returned from books x, (select distinct isbn, b1.id_bill,is_returned from borrowings b1, bills b2 where b1.id_bill = b2.id_bill) y where x.isbn = y.isbn) y where x.id_bill = y.id_bill and x.id_bill = 50) y where x.id_reader = y.id_reader;";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            bool sw = false;
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                sw = true;
            }
            if (dt1.Rows.Count > 0)
            {
                dataGridView2.DataSource = dt1;
                sw = true;
            }
            if (!sw) MessageBox.Show("Error to generate the bill. Sorry.");
            con.Close();
        }
    }
}
