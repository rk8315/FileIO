using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to text file from array
            string[] lines = { "first line", "second line", "third line", "fourth line" };
            File.WriteAllLines(@"C:\Users\Bob\Desktop\test\TextFile2.txt", lines); // this will create the file as well

            // Write to text file with user input
            Console.WriteLine("Enter filename: " );
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter contents of file: ");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Bob\Desktop\test\" + fileName + ".txt", input);

            // Write using streamWriter
            using (StreamWriter file = new StreamWriter(@"C:\Users\Bob\Desktop\test\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            
            /*
            // Reading text of whole file
            string text = System.IO.File.ReadAllText(@"C:\Users\Bob\Desktop\test\TextFile.txt");
            Console.WriteLine("Text file contains following text:\n {0}", text);

            // Reading line by line
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Bob\Desktop\test\TextFile.txt");
            Console.WriteLine("Contents of file = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */






            Console.ReadKey();

        }
    }
}
