using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {

        }

        public bool ConsumesFoodForEnergy { get; set; }
        public bool Reproduces { get; set; }
        public bool RespondsToStimuli { get; set; }
        public bool Grows { get; set; }

        public string Name { get; set; }



    }
}
