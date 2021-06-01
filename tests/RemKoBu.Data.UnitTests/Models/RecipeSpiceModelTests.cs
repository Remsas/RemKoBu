using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeSpiceModelTests
    {
        [Test]
        public void PropertyRecipeSpiceId_SetValue_StoresCorrectly()
        {
            RecipeSpiceModel recipeSpiceModel = new RecipeSpiceModel {RecipeSpiceId = 111};
            Assert.AreEqual(111, recipeSpiceModel.RecipeSpiceId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            RecipeSpiceModel recipeSpiceModel = new RecipeSpiceModel {RecipeId = 222};
            Assert.AreEqual(222, recipeSpiceModel.RecipeId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceId_SetValue_StoresCorrectly()
        {
            RecipeSpiceModel recipeSpiceModel = new RecipeSpiceModel {SpiceId = 333};
            Assert.AreEqual(333, recipeSpiceModel.SpiceId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceQuantity_SetValue_StoresCorrectly()
        {
            RecipeSpiceModel recipeSpiceModel = new RecipeSpiceModel {SpiceQuantity = 444};
            Assert.AreEqual(444, recipeSpiceModel.SpiceQuantity, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceMeasureUnit_SetValue_StoresCorrectly()
        {
            RecipeSpiceModel recipeSpiceModel = new RecipeSpiceModel {SpiceMeasureUnit = "A measure unit"};
            Assert.AreEqual("A measure unit", recipeSpiceModel.SpiceMeasureUnit);
        }
    }
}