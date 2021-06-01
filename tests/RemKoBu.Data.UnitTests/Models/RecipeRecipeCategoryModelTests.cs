using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeRecipeCategoryModelTests
    {
        [Test]
        public void PropertyRecipeRecipeCategoryId_SetValue_StoresCorrectly()
        {
            RecipeRecipeCategoryModel recipeRecipeCategoryModel = new RecipeRecipeCategoryModel();
            recipeRecipeCategoryModel.RecipeRecipeCategoryId = 111;
            Assert.AreEqual(111, recipeRecipeCategoryModel.RecipeRecipeCategoryId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            RecipeRecipeCategoryModel recipeRecipeCategoryModel = new RecipeRecipeCategoryModel();
            recipeRecipeCategoryModel.RecipeId = 222;
            Assert.AreEqual(222, recipeRecipeCategoryModel.RecipeId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyCategoryId_SetValue_StoresCorrectly()
        {
            RecipeRecipeCategoryModel recipeRecipeCategoryModel = new RecipeRecipeCategoryModel();
            recipeRecipeCategoryModel.RecipeCategoryId = 333;
            Assert.AreEqual(333, recipeRecipeCategoryModel.RecipeCategoryId, 0, "stores incorrectly");
        }
    }
}