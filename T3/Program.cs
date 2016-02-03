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
            List<Programme> programmes = new List<Programme>();
            programmes.Add(new Programme { Name = "X-Files", Channel = "Fox", BTime = 22.50, ETime = 23.50, Info = "Science fiction show" });
            programmes.Add (new Programme{ Name = "Desperate Housewives", Channel = "Liv", BTime = 21.00, ETime = 22.00, Info = "Drama" });
            programmes.Add (new Programme { Name = "Pokemon", Channel = "MTV3", BTime = 10.00, ETime = 10.25, Info = "Japanese animation" });

            Stream writeMultipleStream = new FileStream("MyTVs.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeMultipleStream, programmes);
            writeMultipleStream.Close();

            Stream openStream = new FileStream("MyTVs.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Programme> readProgrammes = (List<Programme>)formatter.Deserialize(openStream);
            openStream.Close();

            foreach (Programme tv in readProgrammes)
            {
                Console.WriteLine("Programmes are {0} {0}", tv.Name, tv.Channel, tv.BTime, tv.ETime, tv.Info);
            }

        }
    }
}
