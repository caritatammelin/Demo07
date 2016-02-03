using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile1 = new System.IO.StreamWriter(@"d:\T2Integers");
            System.IO.StreamWriter outputFile2 = new System.IO.StreamWriter(@"d:\T2Doubless");
            float number = 0;
            

            
            
           // double dluku = double.Parse(line);

           // luku = int.Parse(line)

            do
            {
                Console.WriteLine("Give a number: ");
                string line = Console.ReadLine();
               bool onnistuiko = int.TryParse(line, out number);
                if (onnistuiko == true)
                {
                    
                    outputFile1.WriteLine(number);
                }
                else 
                {
                    
                    outputFile2.WriteLine(number);
                }

            } while (!number.Equals(""));
            outputFile1.Close();
            outputFile2.Close();
        }
    }
}
