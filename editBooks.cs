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
    public partial class editBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        string isbn = null;
        public editBooks()
        {
            InitializeComponent();
            button2.Hide();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select isbn ISBN,title Title, author Author, gender Gender, feedback Feedback, buy_price 'Buy Price',borrow_price 'Borrow Price',no_existing 'Books number',no_borr 'Books fosr borrowing',no_borrowed 'Borrowed books' from books;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                isbn = textBox1.Text;
            }
            else MessageBox.Show("We have issues. Try later.");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select isbn ISBN,title Title, author Author, gender Gender, feedback Feedback, buy_price 'Buy Price',borrow_price 'Borrow Price',no_existing 'Books number',no_borr 'Books fosr borrowing',no_borrowed 'Borrowed books' from books where isbn like '%" + textBox1.Text + "%';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                isbn = textBox1.Text;
                button2.Show();
            }
            else MessageBox.Show("Nothing to show.");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string upd = "update books set ";
            int count = 0;
            if (numericUpDown1.Value!=0)
            {
                upd += "buy_price=" + convertDecimalToReal(numericUpDown1.Value);
                ++count;
            }
            if (numericUpDown2.Value != 0)
            {
                if (count > 0) upd += ", ";
                upd += "borrow_price=" + convertDecimalToReal(numericUpDown2.Value);
                ++count;
            }
            if (numericUpDown3.Value != 0)
            {
                if (count > 0) upd += ", ";
                upd += "penalty_price=" + convertDecimalToReal(numericUpDown3.Value);
                ++count;
            }
            if (numericUpDown4.Value != 0)
            {
                if (count > 0) upd += ", ";
                upd += "no_existing=" + numericUpDown4.Value;
                ++count;
            }
            if(numericUpDown4.Value != 0)
            {
                if (count > 0) upd += ", ";
                upd += "no_borr=" + numericUpDown5.Value;
                ++count;
            }
            if (count > 0)
            {
                con.Open();
                upd += " where isbn like '%" + isbn + "%';";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = upd;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated.");
                con.Close();
            }
            else
            {
                MessageBox.Show("At least one field must be filled.");
            }
        }

        private void editBooks_Load(object sender, EventArgs e)
        {
            
        }

        private string convertDecimalToReal(decimal z)
        {
            double x = (double)z;
            return ((int)x).ToString() + '.' + ((int)((x - (int)x) * 10)).ToString();
        }
    }
}
