using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace Application3
{

    public class FileManager
    {
        private string path; //CSV file path
        private int fileExists;
        public List<String> dataLines { get; }
        public List<String> allLines { get;  }
        public String varLine { get; }


        public FileManager()
        {
            string subPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            path = subPath + "\\" + "data-temp.csv";
            fileExists = checkFilePath(path);

            //Read the file and append all the lines to a list
            varLine   = File.ReadAllLines(path).First();
            dataLines = File.ReadAllLines(path).Skip(1).ToList();
            allLines  = File.ReadAllLines(path).ToList();
        }



        /*
         * Check if the file exists given its path
         */
        private int checkFilePath(string path)
        {

            if (File.Exists(path))
            {
                System.Console.WriteLine("File found in " + path);
                return 1;
            }
            else
            {
                System.Console.WriteLine("File doesn't exist! Please check if path is correct and retry.");
                return 0;
            }
        }

    }
}
