using CSharpFunctionalExtensions;
using Logic.Recipies;
using Xunit;

namespace test
{
    public class RecipieShould
    {
        [Fact]
        public void HaveATitle()
        {
            Result<Recipie> sut = Recipie.Create("Crema de calabaza");
            Assert.IsType<Result<Recipie>>(sut);
            Assert.True(sut.IsSuccess);
            Assert.NotEmpty(sut.Value.Title);
        }
    }
}
