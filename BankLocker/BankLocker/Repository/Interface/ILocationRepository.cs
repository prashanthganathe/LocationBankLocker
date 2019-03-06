using BankLocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankLocker.Repsitory
{
    public interface ILocationRepository
    {
        Task<IEnumerable<LocationModel>> GetAllLocationsAsync();       
      
    }
}
