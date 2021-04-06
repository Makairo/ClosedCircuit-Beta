using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosedCircuit.Models
{
    public class EFGameRepo : IGameRepo
    {
        private CCGameDBContext context;

        public EFGameRepo(CCGameDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Round> Rounds => context.Rounds;
    }
}
