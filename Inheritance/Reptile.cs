using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public int NumLegs { get; set; }
        public bool HasShell { get; set; }
        public bool IsVenomous { get; set; }
        public bool IsAmphibious { get; set; }
    }
}
