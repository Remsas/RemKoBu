using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeIngredientModelTests
    {
        [Test]
        public void PropertyRecipeIngredientId_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel {RecipeIngredientId = 111};
            Assert.AreEqual(111, recipeIngredientModel.RecipeIngredientId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel {RecipeId = 222};
            Assert.AreEqual(222, recipeIngredientModel.RecipeId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientId_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel {IngredientId = 333};
            Assert.AreEqual(333, recipeIngredientModel.IngredientId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientQuantity_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel {IngredientQuantity = 444};
            Assert.AreEqual(444, recipeIngredientModel.IngredientQuantity, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientMeasureUnit_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel
            {
                IngredientMeasureUnit = "A measure unit"
            };
            Assert.AreEqual("A measure unit", recipeIngredientModel.IngredientMeasureUnit);
        }

        [Test]
        public void PropertyGrammPerIngredientMeasureUnit_SetValue_StoresCorrectly()
        {
            RecipeIngredientModel recipeIngredientModel = new RecipeIngredientModel
            {
                GrammPerIngredientMeasureUnit = 555
            };
            Assert.AreEqual(555, recipeIngredientModel.GrammPerIngredientMeasureUnit, 0, "stores incorrectly");
        }
    }
}