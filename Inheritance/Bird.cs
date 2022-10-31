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
            ConsumesFoodForEnergy = true;
            Grows = true;
            Reproduces = true;
            RespondsToStimuli = true;
        }
        public bool CanFly { get; set; }
        public bool LaysEggs { get; set; }
        public bool HasFeathers { get; set; }
        public bool HasBeak { get; set; }


    }
}
