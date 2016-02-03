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
            int number = 0;
            bool result;

            
 
            do
            {
                Console.WriteLine("Give a number: ");
                string line = Console.ReadLine();
               result = int.TryParse(line, out number);
                if (result)
                {
                    
                    outputFile1.WriteLine(line);
                }
                else 
                {
                    
                    outputFile2.WriteLine(line);
                }

            } while (!number.Equals(""));
            outputFile1.Close();
            outputFile2.Close();
        }
    }
}
