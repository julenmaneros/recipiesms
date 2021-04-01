using System.ComponentModel.DataAnnotations;

namespace recipiesms.Models
{
    public class RecipieForCreationDto
    {
        [Required(ErrorMessage="Title is required for the recipie")]
        [MaxLength(50)]
        public string Title { get; set; }
    }
}