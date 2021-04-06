using Microsoft.EntityFrameworkCore;

namespace ClosedCircuit.Models
{
    public class CCGameDBContext : DbContext
    {
        public CCGameDBContext(DbContextOptions<CCGameDBContext> options) : base(options) { }
        public DbSet<Round> Rounds { get; set; }
    }
}
