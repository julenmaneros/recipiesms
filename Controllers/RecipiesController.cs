using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace recipiesms.Controllers
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

        [HttpGet("{id}")]
        public IActionResult GetRecipie(int id)
        {
            var recipie = RecipiesDataStore.Current.Recipies.FirstOrDefault(r => r.Id == id);

            if (recipie == null)
            {
                return NotFound();
            }

            return Ok(recipie);
        }
    }
}