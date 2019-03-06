using BankLocker.Context;
using BankLocker.Models;
using BankLocker.Repository.Interface;
using BankLocker.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Repository
{
    public class LockcerRepository : Repository<LockerModel>, ILockerRepository
    {
        BankLockerContext db;
        public LockcerRepository(BankLockerContext _db) : base(_db)
        {

        }     

        public async Task<IEnumerable<LockerModel>> GetAllLockersByBank(int bankid)
        {
            var locations = await GetAllLockersByBank(bankid);
            return locations.OrderBy(x => x.Name);
        }
    }
}
