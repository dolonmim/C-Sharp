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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int  count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex==-1)
            {
                MessageBox.Show("please select your payment method ");
            }
            else
            {
                Form3 form = new Form3();
                form.Tag = this;
                form.Show();
                Hide();
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Tag = this;
            form.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
