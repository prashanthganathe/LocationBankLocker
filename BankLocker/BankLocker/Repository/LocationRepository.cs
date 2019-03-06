using BankLocker.Context;
using BankLocker.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BankLocker.Repsitory
{
    public class LocationRepository : Repository<LocationModel>,ILocationRepository
    {
        BankLockerContext db;
        public LocationRepository(BankLockerContext _db):base(_db)
        {
            
        }
        
        public async Task<IEnumerable<LocationModel>> GetAllLocationsAsync()
        {
            var locations = await FindAllAsync();
            return locations.OrderBy(x => x.Name);
        }

        public async Task UpdateOwnerAsync(LocationModel dbOwner, LocationModel owner)
        {
           // dbOwner.Map(owner);
            Update(dbOwner);
            await SaveAsync();
        }

        public async Task DeleteOwnerAsync(LocationModel owner)
        {
            Delete(owner);
            await SaveAsync();
        }
    }
}
