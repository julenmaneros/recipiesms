using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using service.Models;

namespace service.Controllers
{
    [ApiController]
    [Route("api/recipies")]
    public class RecipiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecipies()
        {
            return Ok(RecipiesDataStore.Current.Recipies);
        }

        [HttpGet("{id}", Name = "GetRecipie")]
        public IActionResult GetRecipie(int id)
        {
            var recipie = RecipiesDataStore.Current.Recipies.FirstOrDefault(r => r.Id == id);

            if (recipie == null)
            {
                return NotFound();
            }

            return Ok(recipie);
        }

        [HttpPost]
        public IActionResult CreateRecipie([FromBody] RecipieForCreationDto recipie)
        {
            if (recipie.Title.Contains("kaka"))
            {
                ModelState.AddModelError("Title", "kaka is not allowed in the title.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var recipieId = RecipiesDataStore.Current.Recipies.Count + 1;

            var finalRecipie = new RecipieDto()
            {
                Id = recipieId,
                Title = recipie.Title
            };

            RecipiesDataStore.Current.Recipies.Add(finalRecipie);

            return CreatedAtRoute("GetRecipie", new { id = recipieId }, finalRecipie);
        }
    }
}