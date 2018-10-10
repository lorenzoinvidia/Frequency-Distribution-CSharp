using System;
using System.Collections.Generic;

namespace Application2
{
    public class ApplicationLogic
    {

        private List<Person> people { get; set; }

        public ApplicationLogic()
        {
            this.people = new List<Person>();
        }


        /*
         * Create the data buffer
         */
        public List<Person> createDataBuffer(FileManager file)
        {
            //Create an array of splitted strings
            foreach (var line in file.Lines)
            {
                String[] splittedLine = line.Split(';');
                //Console.WriteLine(splittedLine[0] + " " + splittedLine[1]);//DEBUG

                //Fill a person object
                people.Add(new Person()
                {
                    Age    = Convert.ToInt32(splittedLine[1]),
                    Gender = Convert.ToChar(splittedLine[0]),
                    Weight = Convert.ToDouble(splittedLine[2]),
                    Height = Convert.ToDouble(splittedLine[3])
                });
            }//foreach

            return people;
            
        }//createDataBuffer()


        /*
         * Calculate the frequency distribution
         */
        public string frequencyDistribution(List<Person> people)
        {
            //Console.WriteLine("frequencyDistribution()");//DEBUG

            string s = "";
            int numOfMales   = 0;
            int numOfFemales = 0;
            int numOfM21 = 0, numOfF21 = 0;
            int numOfM22 = 0, numOfF22 = 0;
            int numOfM23 = 0, numOfF23 = 0;
            int numOfM24 = 0, numOfF24 = 0;
            int numOfM25 = 0, numOfF25 = 0;

            foreach (Person p in people)
            {
                if (p.Gender == 'M')
                {
                    numOfMales += 1;

                    switch (p.Age) {
                        case 21:
                            numOfM21 += 1;
                            break;
                        case 22:
                            numOfM22 += 1;
                            break;
                        case 23:
                            numOfM23 += 1;
                            break;
                        case 24:
                            numOfM24 += 1;
                            break;
                        case 25:
                            numOfM25 += 1;
                            break;
                        default:
                            break;   
                    }//siwtch
                }//if

                if (p.Gender == 'F')
                {
                    numOfFemales += 1;

                    switch (p.Age)
                    {
                        case 21:
                            numOfF21 += 1;
                            break;
                        case 22:
                            numOfF22 += 1;
                            break;
                        case 23:
                            numOfF23 += 1;
                            break;
                        case 24:
                            numOfF24 += 1;
                            break;
                        case 25:
                            numOfF25 += 1;
                            break;
                        default:
                            break;
                    }//switch
                }//if
            }//foreach


            s = numOfM21 + " males are 21 yo\r\n" +
                numOfM22 + " males are 22 yo\r\n" +
                numOfM23 + " males are 23 yo\r\n" +
                numOfM24 + " males are 24 yo\r\n" +
                numOfM25 + " males are 25 yo\r\n" +
                "\r\n" +
                numOfF21 + " females are 21 yo\r\n" +
                numOfF22 + " females are 22 yo\r\n" +
                numOfF23 + " females are 23 yo\r\n" +
                numOfF24 + " females are 24 yo\r\n" +
                numOfF25 + " females are 25 yo\r\n";

            //Console.WriteLine(s);//DEBUG
            return s;

        }//frequencyDistribution()



    }//Class
}//namespace