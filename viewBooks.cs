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
    public partial class viewBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        bool isLib;
        bool secondClick = false;
        int index;
        public viewBooks(bool isLib)
        {
            InitializeComponent();
            this.isLib = isLib;
        }

        private void viewBooks_Load(object sender, EventArgs e)
        {
            numericUpDown1.Hide();
            numericUpDown2.Hide();
            textBox1.Hide();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string s = "select isbn ISBN,title Title, author Author, gender Gender, feedback Feedback, buy_price 'Buy Price',borrow_price 'Borrow Price',no_existing 'Books number',no_borr 'Books fosr borrowing',no_borrowed 'Borrowed books' from books";
            if (isLib) s+=";";
            else s += " where no_existing>0;";
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                dataGridView1.DataSource = dt;
            else MessageBox.Show("We have an issue. Try later.");
            con.Close();
            if (dropDownList1.SelectedValue != "")
                label1.Text = "You choose to search by";
            else label1.Text = "Choose the search criterion";
        }

        private ComboBox GetDropDownList1()
        {
            return dropDownList1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dropDownList1.SelectedIndex;
            if (!secondClick)
            {
                numericUpDown1.Hide();
                numericUpDown2.Hide();
                textBox1.Hide();
                string s;
                index = i;
                if (index < 5)
                {
                    textBox1.Show();
                    s = "Complete the field, then press the search button again.";
                }
                else
                {
                    numericUpDown1.Show();
                    numericUpDown2.Show();
                    s = "Complete the fields, then press the search button again.";
                }
                MessageBox.Show(s);
                secondClick = true;
            }
            else
            {
                if (index != i)
                {
                    numericUpDown1.Hide();
                    numericUpDown2.Hide();
                    textBox1.Hide();
                    string s;
                    index = i;
                    if (index < 5)
                    {
                        textBox1.Text = "";
                        textBox1.Show();
                        s = "Complete the field, then press the search button again.";
                    }
                    else
                    {
                        numericUpDown1.Value = 0;
                        numericUpDown2.Value = 0;
                        numericUpDown1.Show();
                        numericUpDown2.Show();
                        s = "Complete the fields, then press the search button again.";
                    }
                    MessageBox.Show(s);
                }
                else
                {
                    string s= "select isbn ISBN,title Title, author Author, gender Gender, feedback Feedback, buy_price 'Buy Price',borrow_price 'Borrow Price',no_existing 'Books number',no_borr 'Books fosr borrowing',no_borrowed 'Borrowed books' from books";
                    switch (index)
                    {
                        case 1://isbn
                            {
                                s += " where isbn like '%" + textBox1.Text + "%'";
                                break;
                            }
                        case 2://title
                            {
                                s += " where lower(title) like lower('%" + textBox1.Text + "%')";
                                break;
                            }
                        case 3://author
                            {
                                s += " where lower(author) like lower('%" + textBox1.Text + "%')";
                                break;
                            }
                        case 4://gender
                            {
                                s += " where lower(title) like lower('%" + textBox1.Text + "%')";
                                break;
                            }
                        case 5://buyPrice
                            {
                                int a = (int)numericUpDown1.Value;
                                int b = (int)numericUpDown2.Value;
                                if(a>b) { int aux = a; a = b; b = aux; }
                                s += " select * from books where buy_price between " + a + " and " + b;
                                break;
                            }
                        case 6://borrowPrice
                            {
                                int a = (int)numericUpDown1.Value;
                                int b = (int)numericUpDown2.Value;
                                if (a > b) { int aux = a; a = b; b = aux; }
                                s += " select * from books where borrow_price between " + a + " and " + b;
                                break;
                            }
                        case 7://feedback
                            {
                                int a = (int)numericUpDown1.Value;
                                int b = (int)numericUpDown2.Value;
                                if (a > b) { int aux = a; a = b; b = aux; }
                                s += " select * from books where feedback between " + a + " and " + b;
                                break;
                            }
                    }
                    if (isLib) s += ";";
                    else
                    {
                        if (index == 0)
                            s += " where";
                        s += " (no_existing>0 or no_borr>0);";
                    }

                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = s;
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                        dataGridView1.DataSource = dt;
                    else MessageBox.Show("Nothing to show");
                    con.Close();
                    secondClick = false;
                }
            }
        }

        private void dropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }
