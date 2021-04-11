using System.Collections.Generic;

namespace service.Models
{
    public class RecipieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<PreparationStepDto> PreparationSteps { get; set; } 
            = new List<PreparationStepDto>();
    }
}