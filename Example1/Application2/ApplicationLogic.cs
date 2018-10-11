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
        public int[] frequencyDistribution(List<Person> people)
        {
            //Console.WriteLine("frequencyDistribution()");//DEBUG

            
            int[] ageArray = new int[10];
            //  numOfM21 ,
            //  numOfM22 ,
            //  numOfM23 ,
            //  numOfM24 ,
            //  numOfM25 ,
            //  numOfF21 ,
            //  numOfF22 ,
            //  numOfF23 ,
            //  numOfF24 ,
            //  numOfF25 ,

            

            foreach (Person p in people)
            {
                if (p.Gender == 'M')
                {
                    switch (p.Age) {
                        case 21:
                            ageArray[0] += 1;
                            break;
                        case 22:
                            ageArray[1] += 1;
                            break;
                        case 23:
                            ageArray[2] += 1;
                            break;
                        case 24:
                            ageArray[3] += 1;
                            break;
                        case 25:
                            ageArray[4] += 1;
                            break;
                        default:
                            break;   
                    }//siwtch
                }//if

                if (p.Gender == 'F')
                {
                    switch (p.Age)
                    {
                        case 21:
                            ageArray[5] += 1;
                            break;
                        case 22:
                            ageArray[6] += 1;
                            break;
                        case 23:
                            ageArray[7] += 1;
                            break;
                        case 24:
                            ageArray[8] += 1;
                            break;
                        case 25:
                            ageArray[9] += 1;
                            break;
                        default:
                            break;
                    }//switch
                }//if
            }//foreach


            return ageArray;
          
        }//frequencyDistribution()



    }//Class
}//namespace