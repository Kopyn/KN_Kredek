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
    public class GuitarsController : ControllerBase
    {
        private IGuitarService _guitarService;
        private readonly DataBaseContext _context;

        public GuitarsController(IGuitarService guitarService, DataBaseContext context)
        {
            _guitarService = guitarService;
            _context = context;
        }

        /// <summary>
        /// returns all guitars
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Guitar>))]
        public IActionResult GetAllGuitars()
        {
            var guitars = _guitarService.Get(_context);
            return Ok(guitars);
        }

        /// <summary>
        /// adds new guitar
        /// </summary>
        /// <param name="guitar"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Guitar guitar)
        {
            int id = _guitarService.Post(guitar, _context);

            return Ok(id);
        }

        /// <summary>
        /// modifies given guitar
        /// </summary>
        /// <param name="id"></param>
        /// <param name="guitar"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Guitar guitar)
        {
            if (id != guitar.Id)
            {
                return Conflict("Podane id są różne");
            }
            else
            {
                var isUpdateSuccessful = _guitarService.Put(id, guitar, _context);

                if (isUpdateSuccessful)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// deletes given guitar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var isDeleteSuccessful = _guitarService.Delete(id, _context);

            if (isDeleteSuccessful)
                return NoContent();

            return NotFound();
        }
    }
}
