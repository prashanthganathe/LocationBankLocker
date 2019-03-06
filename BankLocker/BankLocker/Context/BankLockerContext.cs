using BankLocker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BankLocker.Models.LocationModel;

namespace BankLocker.Context
{
    public class BankLockerContext:DbContext
    {
        internal object locationBank;

        public BankLockerContext(DbContextOptions<BankLockerContext> options): base(options)
        {
        }
        public DbSet<LocationModel> Location { get; set; }
        public DbSet<LocationBank> LocationBank { get; set; }
        public DbSet<LockerModel> Locker { get; set; }
    }
}
