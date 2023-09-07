using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string WingType { get; set; }
        public string BeakType { get; set; }
        public bool Pollinator { get; set; }
        public bool CanFly { get; set; }
    }
}
