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
    public partial class Form7 : Form
    {
        

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Semester 6\OOP2\Task\project\Employee table.mdf;Integrated Security=True;Connect Timeout=30");


        public Form7()
        {
            InitializeComponent();
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMPLOYEE where EMAIL='"+Form6.text2+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label3.Text = Form6.text1;
            label4.Text = Form6.text2;
            disp_data();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
        }
    }
}
