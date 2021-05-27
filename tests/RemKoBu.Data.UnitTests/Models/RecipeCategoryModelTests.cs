using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeCategoryModelTests
    {
        [Test]
        public void PropertyRecipeCategoryId_SetValue_StoresCorrectly()
        {
            RecipeCategoryModel recipeCategoryModel = new RecipeCategoryModel();
            recipeCategoryModel.recipeCategory_id = 111;
            Assert.AreEqual(111, recipeCategoryModel.recipeCategory_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeCategoryName_SetValue_StoresCorrectly()
        {
            RecipeCategoryModel recipeCategoryModel = new RecipeCategoryModel();
            recipeCategoryModel.recipeCategory_name = "A name";
            Assert.AreEqual("A name", recipeCategoryModel.recipeCategory_name);
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            RecipeCategoryModel recipeCategoryModel = new RecipeCategoryModel();
            recipeCategoryModel.image_path = @"C:\good\path";
            Assert.AreEqual(@"C:\good\path", recipeCategoryModel.image_path);
        }
    }
}