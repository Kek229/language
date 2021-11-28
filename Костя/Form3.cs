using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Костя
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            data.b=textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            data.c=textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            data.d=textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            data.e=textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox5.Text = data.a;
        }
    }
}
