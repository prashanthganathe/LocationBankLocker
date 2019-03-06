using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankLocker.Repsitory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankLocker.Controllers.api
{
    [Route("api/[controller]")]
    public class BanksController : Controller
    {
        private ILocationRepository _repository;
        public BanksController(ILocationRepository repository)
        {
            _repository = repository;
        }
        // GET: api/values
        [HttpGet("{id}", Name ="locationid")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var owners = await _repository.GetAllLocationsAsync();
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
