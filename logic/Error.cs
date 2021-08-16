using System.Collections.Generic;
using CSharpFunctionalExtensions;

namespace Logic.RecipiesMicroservice
{
    public sealed class Error : ValueObject
    {
        public string Code { get; }
        public string Message { get; }

        internal Error(string code, string message)
        {
            Code = code;
            Message = message;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
        }
    }

    public static class Errors 
    {
        public static class Recipie
        {
            public static Error TitleIsRequired() =>
                new Error("recipie.title.empty", "Title can't be empty");
        }
    }
}