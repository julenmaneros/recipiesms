using System;
using Logic.Recipies;
using Xunit;

namespace test
{
    public class RecipieShould
    {
        [Fact]
        public void HaveATitle()
        {
            Recipie recipie = new Recipie("Crema de calabaza");
            Assert.IsType<Recipie>(recipie);
        }
    }
}
