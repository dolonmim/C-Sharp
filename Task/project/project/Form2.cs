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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Semester 6\OOP2\Task\project\Menu\Menu.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.text1;
            label4.Text = Form1.text2;
            disp_data();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //INSERT
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO MENU VALUES ('" + textBox3.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";  //empty text box
            textBox2.Text = "";
            textBox3.Text = "";
            disp_data(); //DISPLAY FUNCTION CALL

            MessageBox.Show("Insertion successful!");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MENU";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }


        private void button4_Click(object sender, EventArgs e) //display
        {
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e) //DELETE
        {

            
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from MENU where FOOD = '" + textBox1.Text + "'";
                cmd.CommandText = "delete from MENU where ID = '" + textBox3.Text + "'";
                cmd.CommandText = "delete from MENU where PRICE = '" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                disp_data();
                MessageBox.Show("Deletion successful!");
            
        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["FOOD"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["PRICE"].FormattedValue.ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e) //UPDATE
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update MENU set  FOOD=@FOOD, PRICE=@PRICE where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@FOOD",textBox1.Text);
            cmd.Parameters.AddWithValue("@PRICE",textBox2.Text);
           
            
            cmd.ExecuteNonQuery();
            con.Close();

            disp_data();
            MessageBox.Show("Updation successful!");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "SELECT * from  MENU where FOOD like '" + textBox4.Text + "%'";
            
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
