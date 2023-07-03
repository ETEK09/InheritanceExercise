using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal 
    {
        public Bird() 
        {
        }

        public bool HasWings { get; set; }
        public string HasName { get; set; }

        public bool HasColor { get; set; }

        public bool CanFly { get; set; }

    
    }
}
