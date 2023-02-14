using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public int length { get; set; }
        public bool scales { get; set; }
        public bool canSwim { get; set; }
        public bool canWalk { get; set; }


    }
}
