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
        public JsonResult GetRecipies()
        {
            return new JsonResult(RecipiesDataStore.Current.Recipies);
        }

        [HttpGet("{id}")]
        public JsonResult GetRecipie(int id)
        {
            return new JsonResult(
                RecipiesDataStore.Current.Recipies.FirstOrDefault(r => r.Id == id));
        }
    }
}