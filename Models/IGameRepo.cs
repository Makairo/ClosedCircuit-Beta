using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedCircuit.Models
{
    public interface IGameRepo
    {
        IQueryable<Round> Rounds {get;}
    }
}
