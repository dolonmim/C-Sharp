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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Semester 6\OOP2\Task\project\Employee table.mdf;Integrated Security=True;Connect Timeout=30");
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp_data();
        }



        

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO EMPLOYEE VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' , '" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";  //empty text box
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            disp_data(); //DISPLAY FUNCTION CALL

            MessageBox.Show("Insertion successful!");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
                disp_data();
         }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["USERNAME"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["EMAIL"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["POSTION"].FormattedValue.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)  //DELETE
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EMPLOYEE where ID = '" + textBox1.Text + "'";
            cmd.CommandText = "delete from EMPLOYEE where USERNAME = '" + textBox2.Text + "'";
            cmd.CommandText = "delete from EMPLOYEE where EMAIL = '" + textBox3.Text + "'";

            textBox1.Text = "";  //empty text box
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";



            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();
            MessageBox.Show("Deletion successful!");

        }

        private void button4_Click(object sender, EventArgs e) //UPDATE
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update EMPLOYEE set  USERNAME=@USERNAME, EMAIL=@EMAIL, POSTION=@POSTION where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@USERNAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@EMAIL", textBox3.Text);
            cmd.Parameters.AddWithValue("@POSTION", textBox4.Text);

            textBox1.Text = "";  //empty text box
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();
            MessageBox.Show("Updation successful!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from  EMPLOYEE where USERNAME like '" + textBox5.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

    
