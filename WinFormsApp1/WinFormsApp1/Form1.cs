using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           object button2_Click = Color.Aqua;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object button3_Click = Color.Aqua;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {


            button1.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Aqua;
            button2.BackColor = Color.Aqua;

        }
    }
}
