using CSharpFunctionalExtensions;
using Logic.RecipiesMicroservice;
using Xunit;

namespace test
{
    public class RecipieShould
    {
        [Fact]
        public void HaveATitle()
        {
            Result<Recipie, Error> sut = Recipie.Create(null);
            Assert.True(sut.IsFailure);            
        }
    }
}
