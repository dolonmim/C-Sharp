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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Tag = this;
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("please write your ID number", "Emrty");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("please write your password number", "Emrty");
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("please write your room number", "Emrty");
            }
            else
            {
                Form2 form = new Form2();
                form.Tag = this;
                form.Show();
                Hide();
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
