using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class Recipe_RecipeCategoryModelTests
    {
        [Test]
        public void PropertyRecipeRecipeCategoryId_SetValue_StoresCorrectly()
        {
            Recipe_RecipeCategoryModel recipeRecipeCategoryModel = new Recipe_RecipeCategoryModel();
            recipeRecipeCategoryModel.recipe_recipeCategory_id = 111;
            Assert.AreEqual(111, recipeRecipeCategoryModel.recipe_recipeCategory_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            Recipe_RecipeCategoryModel recipeRecipeCategoryModel = new Recipe_RecipeCategoryModel();
            recipeRecipeCategoryModel.recipe_id = 222;
            Assert.AreEqual(222, recipeRecipeCategoryModel.recipe_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyCategoryId_SetValue_StoresCorrectly()
        {
            Recipe_RecipeCategoryModel recipeRecipeCategoryModel = new Recipe_RecipeCategoryModel();
            recipeRecipeCategoryModel.recipeCategory_id = 333;
            Assert.AreEqual(333, recipeRecipeCategoryModel.recipeCategory_id, 0, "stores incorrectly");
        }
    }
}