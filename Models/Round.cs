using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClosedCircuit.Models
{
    public class Round
    {
        public long ID { get; set; }
        public long RoundNumber { get; set; }
        public int SmallSpawn { get; set; }
        public int FastSpawn { get; set; }
        public int FatSpawn { get; set; }
        public int BigSpawn { get; set; }

    }
}
