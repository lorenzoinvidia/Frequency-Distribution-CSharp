using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Application3
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
            this.comboBox1.Text = "AGE - HEIGHT"; //default

            file = new FileManager();
            application = new ApplicationLogic();
            buffer = application.createDataBuffer(file);

            initComboBox(application.getCombinations());
        }


        /* 
         * Init the combobox 
         */
        private void initComboBox(String[] items) {
            for (int i = 0; i < items.Length; i++) {
                comboBox1.Items.Add(items[i]);
            }
        }
        

        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){}


        //
        private void button1_Click(object sender, EventArgs e){
            addDataText(buffer);
        }


        //
        private void button2_Click(object sender, EventArgs e){
            drawChart(application.frequencyDistribution(buffer, comboBox1.Text));
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


        /*
         * Draw chart
         */
        private void drawChart(List<List<double>> list){

            //init chart
            chart1.Series.Clear();
            var series1 = new Series
            {
                Name = "freqDist",
                Color = Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            this.chart1.Series.Add(series1);

            //Add data
            for (int i = 0; i < list.First().Count; i++) {
                series1.Points.AddXY(list.First().ElementAt(i), list.Last().ElementAt(i));
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
            chart1.Invalidate(); //Redraw the chart

        }
    }
}
