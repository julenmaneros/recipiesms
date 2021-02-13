using System.Collections.Generic;
using recipiesms.Models;

public class RecipiesDataStore
{
    public static RecipiesDataStore Current { get; } = new RecipiesDataStore();
    
    public List<RecipieDto> Recipies { get; set; }

    public RecipiesDataStore()
    {
        Recipies = new List<RecipieDto>()
        {
            new RecipieDto() { Id = 1, Title = "Acelgas a la vasca" },
            new RecipieDto() { Id = 2, Title = "Crema de calabaza" }
        };
    }
}