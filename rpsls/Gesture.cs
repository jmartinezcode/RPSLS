using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Gesture
    {
        public string name;
        public List<string> losesTo;
        public Gesture(string name, List<string> losesTo)
        {
            this.name = name;
            this.losesTo = losesTo;
        }
        
    }
}
