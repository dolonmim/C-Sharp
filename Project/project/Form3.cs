using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("please write your account number", "Emrty");              
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("please write your pin number", "Emrty");
            }
            else
            {
                Form1 form = new Form1();
                form.Tag = this;
                form.Show();
                Close();
                MessageBox.Show("your payment successfully submitted");
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.Tag = this;
            form.Show();
            Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
