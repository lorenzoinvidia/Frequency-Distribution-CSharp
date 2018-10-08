using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button 1 pressed");//DEBUG
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button 2 pressed");//DEBUG
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Text1 changed");//DEBUG
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Text2 changed");//DEBUG
        }
    }


}
