using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ClosedCircuit.Models
{
    public class RoundData
    {
        public static void EnsurePop(IApplicationBuilder app)
        {
            CCGameDBContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<CCGameDBContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Rounds.Any())
            {
                for (int i = 1; i < 101; i++)
                {
                    context.Rounds.AddRange
                    (
                    new Round
                    {
                    
                        RoundNumber = i,
                        SmallSpawn = 5 + i * 5,
                        FatSpawn = 3 + i * 3 ,
                        FastSpawn = 2 + i * 2 ,
                        BigSpawn = 1 + i
                    });
                    context.SaveChanges();
                }
                
                    
               
            }
        }
    }
}
