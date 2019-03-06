using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankLocker.Repository.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankLocker.Controllers.api
{
    [Route("api/[controller]")]
    public class LockerController : Controller
    {
        private ILockerRepository _repository;
        public LockerController(ILockerRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("{id}", Name = "locationid")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var owners = await _repository.GetAllLockersByBank(id);
                return Ok(owners);
            }
            catch (Exception ex)
            {
                // ILogger.LogError($"Some error in the GetAllOwners method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
