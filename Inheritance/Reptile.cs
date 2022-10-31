using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            ConsumesFoodForEnergy = true;
            Grows = true;
            Reproduces = true;
            RespondsToStimuli = true;
        }
        
        public bool HasScales { get; set; }
        public bool LaysEggs { get; set; }
        public bool ColdBlooded { get; set; }
        public bool Sheds { get; set; }

    }
}
