using GlorriJobs.Persistence.Implements.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlorriJobs.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICityService _cityService {  get; }
        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

            // GET: api/<CitiesController>
        [HttpGet]
        public async Task<IActionResult> Get(int pageNumber,int pageSize,bool isPaginated)
        {
           var data=await _cityService.GetAll(pageNumber, pageSize,isPaginated);
            return Ok(data);
        }

        // GET api/<CitiesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CitiesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CitiesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CitiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
