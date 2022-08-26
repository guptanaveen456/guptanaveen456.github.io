﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using System.IO;

namespace FilesConverter
{
    class Converter
    {
        public static void listFilesInDirectory(string directoryPath)
        {
            string[] filePaths =  Directory.GetFiles(directoryPath);

            foreach (string filePath in filePaths)
            {
                //Console.WriteLine(filePath);

                convert(filePath);

            
            }

        
        }

        public static void convert(string filePath)
        {
            string[] words = filePath.Split(@"\");

            string input_fileName = words[words.Length - 1];

            //Console.WriteLine(input_fileName.Substring(0,input_fileName.Length-5));

            string output_fileName = input_fileName.Substring(0, input_fileName.Length - 5);

            var doc = new Document(filePath);

            doc.Save(@"C:\Users\anil.birajdar\Desktop\confl\Outputs" + output_fileName+".md");

        }

        static void Main(string[] args)
        { 

            listFilesInDirectory(@"C:\Users\anil.birajdar\Desktop\confl\ModMOM");

            Console.ReadLine();
        
        }


    }
}
