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


        private void button1_Click(object sender, EventArgs e) {
            //Console.WriteLine("DEBUG: Button 1 pressed");//DEBUG

            //Load file
            FileManager file1 = new FileManager();

            //Start calculation
            ApplicationLogic application = new ApplicationLogic();

            //Create and display the buffer
            addDataText(application.createDataBuffer(file1));

        }

        

        private void button2_Click(object sender, EventArgs e){
            //Console.WriteLine("DEBUG: Button 2 pressed");//DEBUG

            //Load file
            FileManager file1 = new FileManager();

            //Start calculation
            ApplicationLogic application = new ApplicationLogic();
            
            //Calculate frequency distribution
            application.frequencyDistribution(application.createDataBuffer(file1));
        }






        /*
         * Add data text to textbox1
         */
        private void addDataText(List<Person> people)
        {
            //Initialise Default text
            this.textBox1.Text = "";

            //Add the proper text
            foreach (Person p in people)
            {
                string currStr = "Gender:" + p.Gender + ", " + "Age:" + p.Age + ", " + "Weight:" + p.Weight + ", " + "Height:" + p.Height;
                Console.WriteLine(currStr);//DEBUG

                this.textBox1.Text += currStr + "\r\n";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void TextBox2_TextChanged(object sender, EventArgs e) {
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }//Class
}
