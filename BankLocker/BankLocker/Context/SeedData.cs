using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Context
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BankLockerContext(serviceProvider.GetRequiredService<DbContextOptions<BankLockerContext>>()))
            {
                // Look for any movies.
                if (context.Location.Any())
                {
                    return;   // DB has been seeded
                }

                context.Location.AddRange(
                    new Models.LocationModel { Name = "Sydney" },
                    new Models.LocationModel { Name = "Perth" },
                    new Models.LocationModel { Name = "Brisbane" }
               );

                context.LocationBank.AddRange(
                new Models.LocationBank { Name = "SydneyBank001", LocationId=1 },
                new Models.LocationBank { Name = "SydneyBank002" , LocationId = 1 },
                new Models.LocationBank { Name = "SydneyBank003", LocationId = 1 },

                new Models.LocationBank { Name = "Perth001", LocationId = 2 },
                new Models.LocationBank { Name = "Perth002", LocationId = 2 },
                new Models.LocationBank { Name = "Perth003", LocationId = 2 },

                new Models.LocationBank { Name = "BrisbaneA", LocationId = 3 },
                new Models.LocationBank { Name = "BrisbaneB", LocationId = 3 },
                new Models.LocationBank { Name = "BrisbaneC", LocationId = 3 }
                );

                context.Locker.AddRange(
               new Models.LockerModel { Name = "LockerA",  LocationBankId=1},
               new Models.LockerModel { Name = "LockerB", LocationBankId = 1 },

               new Models.LockerModel { Name = "LockerC", LocationBankId = 2 },
               new Models.LockerModel { Name = "LockerD", LocationBankId = 2 },

               new Models.LockerModel { Name = "LockerE", LocationBankId = 3 },
               new Models.LockerModel { Name = "LockerF", LocationBankId = 3 },

               new Models.LockerModel { Name = "LockerG", LocationBankId = 4 },
               new Models.LockerModel { Name = "LockerH", LocationBankId = 4 },

               new Models.LockerModel { Name = "LockerI", LocationBankId = 5 },
               new Models.LockerModel { Name = "LockerJ", LocationBankId = 5 },

               new Models.LockerModel { Name = "LockerK", LocationBankId = 6 },
               new Models.LockerModel { Name = "LockerL", LocationBankId = 6 },

               new Models.LockerModel { Name = "LockerM", LocationBankId = 7 },
               new Models.LockerModel { Name = "LockerN", LocationBankId = 7 },

               new Models.LockerModel { Name = "LockerO", LocationBankId = 8 },
               new Models.LockerModel { Name = "LockerP", LocationBankId = 8 },

               new Models.LockerModel { Name = "LockerQ", LocationBankId = 9 },
               new Models.LockerModel { Name = "LockerJR", LocationBankId = 9 }


                 );
                context.SaveChanges();

            }
        }
    }
}
