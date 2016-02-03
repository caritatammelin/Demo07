using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Programme
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public double BTime { get; set; }
        public double ETime { get; set; }
        public string Info { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " Channel: " + Channel + " BTime: " + BTime + " ETime: " + ETime + " Info: " + Info;
        }

    }
}
