using CSharpFunctionalExtensions;

namespace Logic.RecipiesMicroservice
{
    public class Recipie : Entity
    {
        public string Title { get; }

        internal Recipie()
        {

        }

        private Recipie(string title)
        {
            Title = title;
        }

        public static Result<Recipie, Error> Create(string title)
        {
            if (string.IsNullOrEmpty(title))
                return Errors.Recipie.TitleIsRequired();

            return new Recipie(title);
        }
    }
}