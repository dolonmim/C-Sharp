using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//database connection
using System.Text.RegularExpressions; //regular pattern



namespace lab_task_3
{
    public partial class Form1 : Form
    {

        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Semester 6\OOP2\Task\lab task 3\Data connection\Login.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "select * from LOGIN_TBL where username='" + txtUsername.Text.Trim() + "' and pass='" + txtPassword.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password!");
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) == true)
            {
                txtUsername.Focus();
                errorProvider1.SetError(this.txtUsername, "Name cannot be empty");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (Regex.IsMatch(txtUsername.Text, pattern) == false)
            {
                txtUsername.Focus();
                errorProvider2.SetError(this.txtUsername, "Invalid Email!");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

        }
    }
}
