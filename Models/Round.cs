using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedCircuit.Models
{
    public class Round
    {
        public int RoundNumber { get; set; }
        public int SmallSpawn { get; set; }
        public int FastSpawn { get; set; }
        public int FatSpawn { get; set; }
        public int BigSpawn { get; set; }

    }
}
