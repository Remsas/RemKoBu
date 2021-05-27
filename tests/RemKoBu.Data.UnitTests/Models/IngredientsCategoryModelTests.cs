using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class IngredientsCategoryModelTests
    {
        [Test]
        public void PropertyIngredientsCategoryId_SetValue_StoresCorrectly()
        {
            IngredientsCategoryModel ingredientsCategoryModel = new IngredientsCategoryModel();
            ingredientsCategoryModel.ingredientsCategory_id = 111;
            Assert.AreEqual(111, ingredientsCategoryModel.ingredientsCategory_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientsCategoryName_SetValue_StoresCorrectly()
        {
            IngredientsCategoryModel ingredientsCategoryModel = new IngredientsCategoryModel();
            ingredientsCategoryModel.ingredientsCategory_name = "A category";
            Assert.AreEqual("A category", ingredientsCategoryModel.ingredientsCategory_name);
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            IngredientsCategoryModel ingredientsCategoryModel = new IngredientsCategoryModel();
            ingredientsCategoryModel.image_path = @"C:\good\path";
            Assert.AreEqual(@"C:\good\path", ingredientsCategoryModel.image_path);
        }
    }
}