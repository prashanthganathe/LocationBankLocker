using BankLocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Repository.Interface
{
    public interface ILockerRepository
    {
       
            Task<IEnumerable<LockerModel>> GetAllLockersByBank(int bankid);
     
    }
}
