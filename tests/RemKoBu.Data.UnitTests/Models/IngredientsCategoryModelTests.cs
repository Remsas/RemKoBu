using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class IngredientsCategoryModelTests
    {
        [Test]
        public void PropertyIngredientsCategoryId_SetValue_StoresCorrectly()
        {
            IngredientCategoryModel ingredientCategoryModel = new IngredientCategoryModel {IngredientCategoryId = 111};
            Assert.AreEqual(111, ingredientCategoryModel.IngredientCategoryId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientsCategoryName_SetValue_StoresCorrectly()
        {
            IngredientCategoryModel ingredientCategoryModel = new IngredientCategoryModel
            {
                IngredientCategoryName = "A category"
            };
            Assert.AreEqual("A category", ingredientCategoryModel.IngredientCategoryName);
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            IngredientCategoryModel ingredientCategoryModel = new IngredientCategoryModel {ImagePath = @"C:\good\path"};
            Assert.AreEqual(@"C:\good\path", ingredientCategoryModel.ImagePath);
        }
    }
}