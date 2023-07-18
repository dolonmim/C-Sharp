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


namespace project
{
    
    public partial class Form1 : Form
    {
       

        public static string text1;
        public static string text2;
        public static string text3;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                text1 = textBox1.Text;
                text2 = textBox2.Text;
                text3 = textBox3.Text;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Semester 6\OOP2\Task\project\Admin login\admin login table.mdf;Integrated Security=True;Connect Timeout=30");
             {
                    string query = "select * from ADMIN_LOGIN where username='" + textBox1.Text.Trim() + "'and email='" + textBox2.Text.Trim() + "'and pass='" + textBox3.Text.Trim() + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);


                    DataTable dtbl = new DataTable();


                    sda.Fill(dtbl);



                    if (dtbl.Rows.Count == 1)
                    {
                        Form4 form4 = new Form4();
                        this.Hide();
                        form4.Show();
                    }

                    else
                    {
                        MessageBox.Show("Invalid!Please enter correct one");
                    }



                }
            }


        

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); 
            this.Hide();
            form3.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Email cannot be empty");
            }
            else
            {
                errorProvider1.Clear();
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Name cannot be empty");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Password cannot be empty");
            }
            else
            {
                errorProvider3.Clear();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
