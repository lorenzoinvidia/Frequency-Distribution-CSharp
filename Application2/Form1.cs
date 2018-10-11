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
            int[] ageArray = application.frequencyDistribution(buffer);

            this.textBox2.Text = ageArray[0] + " males are 21 yo\r\n" +
                                 ageArray[1] + " males are 22 yo\r\n" +
                                 ageArray[2] + " males are 23 yo\r\n" +
                                 ageArray[3] + " males are 24 yo\r\n" +
                                 ageArray[4] + " males are 25 yo\r\n" +
                                 "\r\n" +
                                 ageArray[5] + " females are 21 yo\r\n" +
                                 ageArray[6] + " females are 22 yo\r\n" +
                                 ageArray[7] + " females are 23 yo\r\n" +
                                 ageArray[8] + " females are 24 yo\r\n" +
                                 ageArray[9] + " females are 25 yo\r\n"; ;

             //Draw chart
             draWChart(ageArray);
            
        }


        /*
         * Draw chart
         */
        private void draWChart(int[] ageArray)
        {
            //Add data
            this.chart1.Series["M"].Points.AddXY("21 yo", ageArray[0]);
            this.chart1.Series["F"].Points.AddXY("21 yo", ageArray[5]);

            this.chart1.Series["M"].Points.AddXY("22 yo", ageArray[1]);
            this.chart1.Series["F"].Points.AddXY("22 yo", ageArray[6]);

            this.chart1.Series["M"].Points.AddXY("23 yo", ageArray[2]);
            this.chart1.Series["F"].Points.AddXY("23 yo", ageArray[7]);

            this.chart1.Series["M"].Points.AddXY("24 yo", ageArray[3]);
            this.chart1.Series["F"].Points.AddXY("24 yo", ageArray[8]);

            this.chart1.Series["M"].Points.AddXY("25 yo", ageArray[4]);
            this.chart1.Series["F"].Points.AddXY("25 yo", ageArray[9]);
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
