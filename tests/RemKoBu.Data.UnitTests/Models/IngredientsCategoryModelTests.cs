using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class IngredientsCategoryModelTests
    {
        [Test]
        public void PropertyIngredientsCategoryId_SetValue_StoresCorrectly()
        {
            IngredientCategoryModel ingredientCategoryModel = new IngredientCategoryModel();
            ingredientCategoryModel.IngredientsCategoryId = 111;
            Assert.AreEqual(111, ingredientCategoryModel.IngredientsCategoryId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientsCategoryName_SetValue_StoresCorrectly()
        {
            IngredientCategoryModel ingredientCategoryModel = new IngredientCategoryModel();
            ingredientCategoryModel.IngredientsCategoryName = "A category";
            Assert.AreEqual("A category", ingredientCategoryModel.IngredientsCategoryName);
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            IngredientCategoryModel ingredientCategoryModel = new IngredientCategoryModel();
            ingredientCategoryModel.ImagePath = @"C:\good\path";
            Assert.AreEqual(@"C:\good\path", ingredientCategoryModel.ImagePath);
        }
    }
}