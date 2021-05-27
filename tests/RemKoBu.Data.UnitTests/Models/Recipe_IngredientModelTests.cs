using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class Recipe_IngredientModelTests
    {
        [Test]
        public void PropertyRecipeIngredientId_SetValue_StoresCorrectly()
        {
            Recipe_IngredientModel recipeIngredientModel = new Recipe_IngredientModel();
            recipeIngredientModel.recipe_ingredient_id = 111;
            Assert.AreEqual(111, recipeIngredientModel.recipe_ingredient_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            Recipe_IngredientModel recipeIngredientModel = new Recipe_IngredientModel();
            recipeIngredientModel.recipe_id = 222;
            Assert.AreEqual(222, recipeIngredientModel.recipe_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientId_SetValue_StoresCorrectly()
        {
            Recipe_IngredientModel recipeIngredientModel = new Recipe_IngredientModel();
            recipeIngredientModel.ingredient_id = 333;
            Assert.AreEqual(333, recipeIngredientModel.ingredient_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientQuantity_SetValue_StoresCorrectly()
        {
            Recipe_IngredientModel recipeIngredientModel = new Recipe_IngredientModel();
            recipeIngredientModel.ingredient_quantity = 444;
            Assert.AreEqual(444, recipeIngredientModel.ingredient_quantity, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientMeasureUnit_SetValue_StoresCorrectly()
        {
            Recipe_IngredientModel recipeIngredientModel = new Recipe_IngredientModel();
            recipeIngredientModel.ingredient_measureUnit = "A measure unit";
            Assert.AreEqual("A measure unit", recipeIngredientModel.ingredient_measureUnit);
        }

        [Test]
        public void PropertyGrammPerIngredientMeasureUnit_SetValue_StoresCorrectly()
        {
            Recipe_IngredientModel recipeIngredientModel = new Recipe_IngredientModel();
            recipeIngredientModel.gramm_per_ingredient_measureUnit = 555;
            Assert.AreEqual(555, recipeIngredientModel.gramm_per_ingredient_measureUnit, 0, "stores incorrectly");
        }
    }
}