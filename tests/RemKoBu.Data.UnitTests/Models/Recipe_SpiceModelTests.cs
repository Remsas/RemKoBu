using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class Recipe_SpiceModelTests
    {
        [Test]
        public void PropertyRecipeSpiceId_SetValue_StoresCorrectly()
        {
            Recipe_SpiceModel recipeSpiceModel = new Recipe_SpiceModel();
            recipeSpiceModel.recipe_spice_id = 111;
            Assert.AreEqual(111, recipeSpiceModel.recipe_spice_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            Recipe_SpiceModel recipeSpiceModel = new Recipe_SpiceModel();
            recipeSpiceModel.recipe_id = 222;
            Assert.AreEqual(222, recipeSpiceModel.recipe_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceId_SetValue_StoresCorrectly()
        {
            Recipe_SpiceModel recipeSpiceModel = new Recipe_SpiceModel();
            recipeSpiceModel.spice_id = 333;
            Assert.AreEqual(333, recipeSpiceModel.spice_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceQuantity_SetValue_StoresCorrectly()
        {
            Recipe_SpiceModel recipeSpiceModel = new Recipe_SpiceModel();
            recipeSpiceModel.spice_quantity = 444;
            Assert.AreEqual(444, recipeSpiceModel.spice_quantity, 0, "stores incorrectly");
        }

        [Test]
        public void PropertySpiceMeasureUnit_SetValue_StoresCorrectly()
        {
            Recipe_SpiceModel recipeSpiceModel = new Recipe_SpiceModel();
            recipeSpiceModel.spice_measureUnit = "A measure unit";
            Assert.AreEqual("A measure unit", recipeSpiceModel.spice_measureUnit);
        }
    }
}