using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_task_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            
            Close();
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
