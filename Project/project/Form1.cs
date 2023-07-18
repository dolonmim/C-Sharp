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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("please select your category ");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Form2 form = new Form2();
                    form.Tag = this;
                    form.Show();
                    Hide();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Form4 form = new Form4();
                    form.Tag = this;
                    form.Show();
                    Hide();
                }
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
