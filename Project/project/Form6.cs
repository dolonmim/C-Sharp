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

    public partial class Form6 : Form
    {


        public static string text1;
        public static string text2;
        public static string text3;


        public Form6()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            text1 = textBox4.Text;
            text2 = textBox5.Text;
            text3 = textBox6.Text;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Semester 6\OOP2\Task\project\employee login.mdf;Integrated Security=True;Connect Timeout=30");
            {
                string query = "select * from EMPLOYEE_LOGIN where username='" + textBox4.Text.Trim() + "'and email='" + textBox5.Text.Trim() + "'and pass='" + textBox6.Text.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);


                DataTable dtbl = new DataTable();


                sda.Fill(dtbl);



                if (dtbl.Rows.Count == 1)
                {
                    Form7 form7 = new Form7();
                    this.Hide();
                    form7.Show();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox6.UseSystemPasswordChar = false;
            }
            else
            {
                textBox6.UseSystemPasswordChar = true;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
