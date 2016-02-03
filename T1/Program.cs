using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
        
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string line;
                using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(mydocpath + @"\WriteLines.txt"))
                {
                    do
                    {
                        Console.WriteLine("Write something: ");
                        line = Console.ReadLine();
                        outputFile.WriteLine(line);
                    } while (!line.Equals("")); //(line.Length != 0);
                }

                try
            {
                string text = System.IO.File.ReadAllText(mydocpath + @"\WriteLines.txt");
                System.Console.WriteLine("From inside the file WriteLines.txt: \n" + text);
            } catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
          
         
        }
    }
}
