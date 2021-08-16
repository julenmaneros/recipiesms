using CSharpFunctionalExtensions;
using Logic.RecipiesMicroservice;
using Xunit;

namespace test
{
    public class RecipiesBookShould
    {
        [Fact]
        public void HaveAListOfRecipies()
        {
            Result<RecipieBook, Error> sut = RecipieBook.Create();
            Assert.True(sut.IsSuccess);
            Assert.NotNull(sut.Value.Recipies);
        }
    }    
}