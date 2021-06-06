using System;

namespace Logic.Recipies
{
    public class Recipie : Entity
    {
        public string Title { get; }

        public Recipie(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException();
            }
            Title = title;
        }
    }
}