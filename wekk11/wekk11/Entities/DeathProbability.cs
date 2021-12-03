using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wekk11.Entities
{
    public class DeathProbability
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int NbrOfChildren { get; set; }
        public double P { get; set; }


        
    }
}
