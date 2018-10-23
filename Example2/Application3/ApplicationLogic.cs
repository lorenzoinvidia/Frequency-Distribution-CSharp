using System;
using System.Collections.Generic;
using System.Collections;

namespace Application3
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
            foreach (var line in file.dataLines)
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
         * Get variables from csv
         */
        public String[] getVariables(FileManager file) {
            return file.varLine.Split(';');
        }


        /* 
         * Get combinations of variables (fetch from getVariables if needed)
         */
        public String[] getCombinations() {
            String[] combinations = { "AGE - HEIGHT", "AGE - WEIGHT", "WEIGHT - HEIGHT", "GENDER - AGE" };
            // add more if needed

            return combinations;
        }


        /*
         * Calculate the bivariate distribution (var1 - var2)
         */
        public List<List<Double>> frequencyDistribution(List<Person> people, String variables)
        {
            //Console.WriteLine("frequencyDistribution()");//DEBUG

            List<List<Double>> list;


            List<Double> varX;
            List<Double> varY; 
            
        
            switch (variables)
            {
                case "AGE - HEIGHT":
                    Console.WriteLine("DEBUG: age-height");//DEBUG

                    varX = new List<Double>();
                    varY = new List<Double>();
                    foreach (Person p in people)
                    {
                        varX.Add(p.Age);
                        varY.Add(p.Height);
                    }
                    varX.Sort();
                    varY.Sort();
                    list = new List<List<Double>>() { varX, varY };
                    return list;

                    break;

                case "AGE - WEIGHT":
                    Console.WriteLine("DEBUG: age-weight");//DEBUG

                    varX = new List<Double>();
                    varY = new List<Double>();
                    foreach (Person p in people)
                    {
                        varX.Add(p.Age);
                        varY.Add(p.Weight);
                    }
                    varX.Sort();
                    varY.Sort();
                    list = new List<List<Double>>() { varX, varY };
                    return list;

                    break;

                case "WEIGHT - HEIGHT":
                    Console.WriteLine("DEBUG: weight-height");//DEBUG

                    varX = new List<Double>();
                    varY = new List<Double>();
                    foreach (Person p in people)
                    {
                        varX.Add(p.Weight);
                        varY.Add(p.Height);
                    }
                    varX.Sort();
                    varY.Sort();
                    list = new List<List<Double>>() { varX, varY };
                    return list;

                    break;

                case "GENDER - AGE":
                    Console.WriteLine("DEBUG: gender-age");//DEBUG

                    varX = new List<Double>();
                    varY = new List<Double>();
                    foreach (Person p in people)
                    {
                        varX.Add(p.Gender);
                        varY.Add(p.Weight);
                    }
                    varX.Sort();
                    varY.Sort();
                    list = new List<List<Double>>() { varX, varY };
                    return list;

                    break;

                default:
                    Console.WriteLine("DEBUG: default");//DEBUG

                    varX = new List<Double>();
                    varY = new List<Double>();
                    foreach (Person p in people)
                    {
                        //add nothing
                        varX.Add(0);
                        varY.Add(0);
                    }
                    varX.Sort();
                    varY.Sort();
                    list = new List<List<Double>>() { varX, varY };
                    return list;

                    break;
            }//switch
            
        }//frequencyDistribution()



    }//Class
}//namespace