using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TV> programmes = new List<TV>();
            Programme program = new Programme { Name = "X-Files", Channel = "Fox", BTime = 22.50, ETime = 23.50, Info = "Science fiction show" };
            Programme program2 = new Programme{ Name = "Desperate Housewives", Channel = "Liv", BTime = 21.00, ETime = 22.00, Info = "Drama" };
            Programme program3 = new Programme { Name = "Pokemon", Channel = "MTV3", BTime = 10.00, ETime = 10.25, Info = "Japanese animation" };

            Stream writeMultipleStream = new FileStream("MyTVs.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeMultipleStream, programmes);
            writeMultipleStream.Close();

            Stream openStream = new FileStream("MyTVs.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<TV> readProgrammes = (List<TV>)formatter.Deserialize(openStream);
            openStream.Close();

        }
    }
}
