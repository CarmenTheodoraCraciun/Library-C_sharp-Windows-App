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
    public partial class makeBill : Form
    {
        

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NM96DVG;Initial Catalog=Library;Integrated Security=True");
        public makeBill()
        {
            InitializeComponent();
        }
        private bool writeGood(string s)
        {
            for (int i = 0; i < s.Length; ++i)
            {
                if (i == 13 || i == 27 || i == 41 || i == 55 || i == 69)
                {
                    if (s[i] != ',')
                    {
                        return false;
                        MessageBox.Show("They must be separated by a comma (without spaces)");
                    }
                }
                else if (!('0' <= s[i] && s[i] <= '9'))
                {
                    return false;
                    MessageBox.Show("The ISBN contains 13 digits");
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox2.Text;
            string s2 = textBox3.Text;
            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2))
                MessageBox.Show("At least one field must contain data.");
            else
            {
                if(writeGood(s1) && writeGood(s2))
                    {
                        Dictionary<string, List<double>> d = new Dictionary<string, List<double>>();
                        List<double> l1 = new List<double>(); l1.Add(23.4); l1.Add(32.5); d["9780340951453"] = l1; 
                        List<double> l2 = new List<double>(); l2.Add(45.89); l2.Add(30); d["9781526020369"] = l2;
                        List<double> l3 = new List<double>(); l3.Add(22.41); l3.Add(40); d["9786557823248"] = l3; 
                        List<double> l4 = new List<double>(); l4.Add(23.4); l4.Add(31.8); d["9786557826966"] = l4; 
                        List<double> l5 = new List<double>(); l5.Add(18); l5.Add(25.5); d["9788467503487"] = l5;
                        string[] x1 = s1.Split(',');
                        string[] x2 = s2.Split(',');
                        int sum = 0;
                        for (int i = 0; i < x1.Length; ++i)
                            sum += (int)d[x1[i]][1];
                        for (int i = 0; i < x2.Length; ++i)
                            sum += (int)d[x2[i]][0];
                    ++sum;
                        string s = "insert into bills (id_bill,bill_date,bill_price,id_reader) values (50,GETDATE(),"+sum+",50);";
                        for (int i = 0; i < x1.Length; ++i)
                            s += "\ninsert into boughts (id_boug,date_boug,id_bill,isbn) values (next value for bouid,GETDATE()-30,50,'" + x1[i] + "');";
                        for (int i = 0; i < x2.Length; ++i)
                            s += "\ninsert into borrowings (id_borr,date_borr,date_for_return,is_returned,id_bill,isbn) values (next value for borrid,GETDATE(),GETDATE()+30,'false',50,'" + x2[i] + "');";
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = s;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        showBill sb = new showBill();
                        sb.Show();
                    }
                }
            }

        }

    }
