using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Person> people = new List<Person> {
                new Person(){ Age=21, Gender='M', Weight=64.5, Height=170 },
                new Person(){ Age=25, Gender='F', Weight=64.5, Height=170 },
            };

           
            foreach (Person p in people)
                System.Console.WriteLine("Age:" + p.Age + " " + "Weight:" + p.Weight);


            Application.Run(new Form1());
        }
    }
}
