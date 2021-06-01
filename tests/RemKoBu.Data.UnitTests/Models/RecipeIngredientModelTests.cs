using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeIngredientModelTests
    {
        [Test]
        public void PropertyRecipeIngredientId_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel();
            recipeIngredientModel.RecipeIngredientId = 111;
            Assert.AreEqual(111, recipeIngredientModel.RecipeIngredientId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel();
            recipeIngredientModel.RecipeId = 222;
            Assert.AreEqual(222, recipeIngredientModel.RecipeId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientId_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel();
            recipeIngredientModel.IngredientId = 333;
            Assert.AreEqual(333, recipeIngredientModel.IngredientId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientQuantity_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel();
            recipeIngredientModel.IngredientQuantity = 444;
            Assert.AreEqual(444, recipeIngredientModel.IngredientQuantity, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientMeasureUnit_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel();
            recipeIngredientModel.IngredientMeasureUnit = "A measure unit";
            Assert.AreEqual("A measure unit", recipeIngredientModel.IngredientMeasureUnit);
        }

        [Test]
        public void PropertyGrammPerIngredientMeasureUnit_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel();
            recipeIngredientModel.GrammPerIngredientMeasureUnit = 555;
            Assert.AreEqual(555, recipeIngredientModel.GrammPerIngredientMeasureUnit, 0, "stores incorrectly");
        }
    }
}