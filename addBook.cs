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
    public partial class addBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        public addBook()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (checks())
            {
                string s= "insert into books (isbn,title,author,gender,buy_price,borrow_price,penalty_price,no_existing,no_borr) values ('" +
                    textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "',"
                    + convertDecimalToReal(numericUpDown1.Value) + "," + convertDecimalToReal(numericUpDown2.Value) + "," + convertDecimalToReal(numericUpDown3.Value) + ","
                    + (int)numericUpDown4.Value + "," + (int)numericUpDown5.Value + ");";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = s;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added");
                this.Hide();
            }
        }
        private bool checks()
        {
            return checkISBN(textBox1.Text) && checkText(textBox1.Text) && checkText(textBox2.Text)
                && checkText(textBox3.Text) && checkText(textBox4.Text) && uniqueISBN(textBox1.Text)
                && checkNoBooks();
        }
        private bool checkISBN(string s)
        {
            if (s.Length != 13)
            {
                MessageBox.Show("The ISBN contains 13 digits");
                return false;
            }
            for (int i = 0; i < s.Length; ++i)

                if (!('0' <= s[i] && s[i] <= '9'))
                {
                    MessageBox.Show("The ISBN contains 13 digits");
                    return false;
                }
            return true;
        }
        private bool checkText(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                MessageBox.Show("All textbox are mandatory.");
                return false;
            }
            return true;
        }
        private bool uniqueISBN(string s)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select isbn from books where isbn='" + s + "';";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The ISBN already exist in our database.");
                return false;
            }
            return true;
        }
        private bool checkNoBooks()
        {
            if (numericUpDown4.Value == 0 && numericUpDown5.Value == 0)
            {
                MessageBox.Show("Number of books need to be more that 0.");
                return false;
            }
            return true;
        }
        private string convertDecimalToReal(decimal z)
        {
            double x = (double)z;
            return ((int)x).ToString() + '.' + ((int)((x - (int)x) * 10)).ToString();
        }
    }
}
