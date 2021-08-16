using System.Collections.Generic;
using CSharpFunctionalExtensions;

namespace Logic.RecipiesMicroservice
{
    public class RecipieBook : Entity
    {
        public List<Recipie> Recipies { get; }

        private RecipieBook()
        {
            Recipies = new List<Recipie>();
        }

        public static Result<RecipieBook, Error> Create()
        {
            return new RecipieBook();
        }

        public void AddRecipie(Recipie recipie) {
            Recipies.Add(recipie);
        }
    }
}