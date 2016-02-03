using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    [Serializable]
    class TV
    {
        public List<Programme> Programmes { get; }
        public TV()
        {
            Programmes = new List<Programme>();
        }
        public void AddProgramme(Programme tv)
        {
            Programmes.Add(tv);
        }

        public override string ToString()
        {
            string sTV = "Programme data:\n";
            foreach (Programme tv in Programmes)
            {
                sTV += tv.ToString() + "\n";
            }
            return sTV;
        }

        public void PrintCollection()
        {
            Console.WriteLine("Programmes in collection: ");
            foreach (Programme tv in Programmes)
            {
                Console.WriteLine(tv.ToString());
            }
        }
    }
}
