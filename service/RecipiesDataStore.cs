using System.Collections.Generic;
using service.Models;

public class RecipiesDataStore
{
    public static RecipiesDataStore Current { get; } = new RecipiesDataStore();
    
    public List<RecipieDto> Recipies { get; set; }

    public RecipiesDataStore()
    {
        Recipies = new List<RecipieDto>()
        {
            new RecipieDto() 
            { 
                Id = 1, 
                Title = "Acelgas a la vasca",
                PreparationSteps = new List<PreparationStepDto>()
                {
                    new PreparationStepDto()
                    {
                        Id = 1,
                        Order = 1,
                        Description = "Poner agua con sal abundante a hervir en una cazuela grande. Cortar el queso en tiras de medio centímetro de grosor y con el ancho aproximado de las pencas (no tienen que ser perfectas, porque podremos completar con trozos al usarlas)."
                    },
                    new PreparationStepDto()
                    {
                        Id = 2,
                        Order = 2,
                        Description = "Pelar las patatas y cortarlas en trozos grandes. Separar las pencas de las acelgas, y si son muy largas, cortarlas por la mitad. Cocer las patatas 10 minutos a fuego suave. Añadir las pencas y cocer 10 minutos más. Sumar las hojas de las acelgas cortadas en tiras y cocer un par de minutos. Escurrir reservando dos o tres cucharadas del líquido de cocción."
                    }
                }
            },
            new RecipieDto() 
            { 
                Id = 2, 
                Title = "Crema de calabaza",
                PreparationSteps = new List<PreparationStepDto>()
                {
                    new PreparationStepDto()
                    {
                        Id = 1,
                        Order = 1,
                        Description = "Pon 5 vasos de agua a cocer en una cazuela."
                    },
                    new PreparationStepDto()
                    {
                        Id = 2,
                        Order = 2,
                        Description = "Corta la rodaja de calabaza por la mitad, pélala y córtala primero en tiras y después en dados."
                    },
                    new PreparationStepDto()
                    {
                        Id = 3,
                        Order = 3,
                        Description = "Retira la parte inferior y superior de las zanahorias, pélalas y córtalas en rodajas de 1 centímetro. Limpia el puerro reserva un trozo y corta el resto en rodajas."
                    }
                } 
            }
        };
    }
}