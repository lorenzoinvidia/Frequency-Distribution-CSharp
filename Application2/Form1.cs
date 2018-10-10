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
        private List<Person> buffer;
        private FileManager file;
        private ApplicationLogic application;

        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = "";
            this.textBox2.Text = "";

            file        = new FileManager();
            application = new ApplicationLogic();
            buffer      = application.createDataBuffer(file);
            
        }


        private void button1_Click(object sender, EventArgs e) {
            //Console.WriteLine("DEBUG: Button 1 pressed");//DEBUG

            //Display the buffer
            addDataText(buffer);

        }

        

        private void button2_Click(object sender, EventArgs e){
            //Console.WriteLine("DEBUG: Button 2 pressed");//DEBUG
            
            //Calculate frequency distribution
            this.textBox2.Text = application.frequencyDistribution(buffer);;
        }


        /*
         * Add data text to textbox1
         */
        private void addDataText(List<Person> people)
        {
            //Add the proper text
            foreach (Person p in people)
            {
                string currStr = "Gender:" + p.Gender + ", " + "Age:" + p.Age + ", " + "Weight:" + p.Weight + ", " + "Height:" + p.Height;
                Console.WriteLine(currStr);//DEBUG

                this.textBox1.Text += currStr + "\r\n";
            }
        }


        private void Form1_Load(object sender, EventArgs e) {}

    }//Class
}
