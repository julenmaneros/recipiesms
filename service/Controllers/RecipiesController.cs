using System.Linq;
using System.Threading.Tasks;
using Logic.RecipiesMicroservice;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using service.Data;
using service.Models;

namespace service.Controllers
{
    [ApiController]
    [Route("api/recipies")]
    public class RecipiesController : ControllerBase
    {
        private readonly RecipiesMsDbContext context;

        public RecipiesController(RecipiesMsDbContext context)
        {
            this.context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetRecipies()
        {
            var recipieBook = await context.Set<RecipieBook>().Include(rb => rb.Recipies).SingleAsync();
            return Ok(recipieBook);
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