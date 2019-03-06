using BankLocker.Repsitory;
using BankLocker.Repsitory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankLocker.Models;
using BankLocker.Context;

namespace BankLocker.Repository
{
    public class BankRepository : Repository<LocationBank>, IBankRepository
    {
        BankLockerContext db;
        public BankRepository(BankLockerContext _db):base(_db)
        {

        }
        public async Task<IEnumerable<LocationBank>> GetAllBanksByLocation(int bankid)
        {
            var locations = await GetAllBanksByLocation(bankid);
            return locations.OrderBy(x => x.Name);
        }
    }
}
