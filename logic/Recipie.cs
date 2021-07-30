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

        public static Result<Recipie> Create(string title) {
            
            if (string.IsNullOrEmpty(title))
                return Result.Failure<Recipie>("Title can't be empty");

            return new Recipie(title);
        }
    }
}