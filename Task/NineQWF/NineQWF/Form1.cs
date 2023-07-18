using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NineQWF
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
            if(textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "")
            {
                text1 = textBox1.Text;
                text2 = textBox2.Text;
                text3 = textBox3.Text;

                Form f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Fields cannot be empty!");
            }

            


        }
    }
}
