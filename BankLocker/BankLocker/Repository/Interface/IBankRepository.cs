using BankLocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Repsitory.Interface
{
    public interface IBankRepository
    {
        Task<IEnumerable<LocationBank>> GetAllBanksByLocation(int bankid);
    }
}
