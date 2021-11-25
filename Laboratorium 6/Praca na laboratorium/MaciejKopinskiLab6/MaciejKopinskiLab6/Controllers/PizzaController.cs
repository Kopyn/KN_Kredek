using MaciejKopinskiLab6.Models;
using MaciejKopinskiLab6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        /// <summary>
        /// Zwraca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Pizza>))]
        public IActionResult GetAllPizzas()
        {
            var pizzas = _pizzaService.Get();
            return Ok(pizzas);
        }

        /// <summary>
        /// Dodaje nową pizzę
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody]Pizza pizza)
        {
            int id = _pizzaService.Post(pizza);

            return Ok(id);
        }

        /// <summary>
        /// Edytuje istniejącą pizzę
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute]int id, [FromBody]Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return Conflict("Podane id są różne");
            }
            else
            {
                var isUpdateSuccessful = _pizzaService.Put(id, pizza);

                if (isUpdateSuccessful)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Usuwa istniejącą pizzę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var isDeleteSuccessful = _pizzaService.Delete(id);

            if (isDeleteSuccessful)
                return NoContent();

            return NotFound();
        }
    }
}
