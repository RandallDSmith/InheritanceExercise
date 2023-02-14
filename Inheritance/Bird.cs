using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string type { get; set; }
        public string birdCall { get; set; }
        public int wingSpan { get; set; }
        public int height { get; set; }

    }
}
