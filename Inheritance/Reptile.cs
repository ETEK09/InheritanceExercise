using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal 
    {
        public Reptile() 
        {
                HasHeart = true;
                HasBrain = false;
                HasTeeth = true;
                HasLegs = 4;
        }

        public bool IsAlive { get; set; }
        public bool HasPhangs { get; set; }
        public bool Carnivorus { get; set; }
        public bool HasBabies { get; set; }
    }
}
