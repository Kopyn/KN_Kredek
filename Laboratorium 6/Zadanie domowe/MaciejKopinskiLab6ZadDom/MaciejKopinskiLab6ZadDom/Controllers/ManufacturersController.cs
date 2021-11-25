using MaciejKopinskiLab6ZadDom.Models;
using MaciejKopinskiLab6ZadDom.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6ZadDom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private IManufacturerService _manufacturerService;
        private readonly DataBaseContext _context;

        public ManufacturersController(IManufacturerService manufacturerService, DataBaseContext context)
        {
            _manufacturerService = manufacturerService;
            _context = context;
        }

        /// <summary>
        /// returns all manufacturers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Manufacturer>))]
        public IActionResult GetAllManufacturers()
        {
            var manufacturers = _manufacturerService.Get(_context);
            return Ok(manufacturers);
        }

        /// <summary>
        /// adds new manufacturer
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Manufacturer manufacturer)
        {
            int id = _manufacturerService.Post(manufacturer, _context);

            return Ok(id);
        }

        /// <summary>
        /// modifies given manufacturer
        /// </summary>
        /// <param name="id"></param>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Manufacturer manufacturer)
        {
            if (id != manufacturer.Id)
            {
                return Conflict("Podane id są różne");
            }
            else
            {
                var isUpdateSuccessful = _manufacturerService.Put(id, manufacturer, _context);

                if (isUpdateSuccessful)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// deletes given manufacturer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _manufacturerService.Delete(id, _context);

            if (isDeleteSuccessful)
                return NoContent();

            return NotFound();
        }
    }
}
