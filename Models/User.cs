using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedCircuit.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int HighScore { get; set; }
    }
}
