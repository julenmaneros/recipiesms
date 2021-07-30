using System;
using CSharpFunctionalExtensions;

namespace Logic.Recipies
{
    public class Recipie : Entity
    {
        public string Title { get; }

        private Recipie(string title)
        {
            Title = title;
        }

        public static Result<Recipie, Error> Create(string title) {
            
            if (string.IsNullOrEmpty(title))
                return Errors.Recipie.TitleIsRequired();

            return new Recipie(title);
        }
    }
}