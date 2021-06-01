using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeCategoryModelTests
    {
        [Test]
        public void PropertyRecipeCategoryId_SetValue_StoresCorrectly()
        {
            RecipeCategoryModel recipeCategoryModel = new RecipeCategoryModel {RecipeCategoryId = 111};
            Assert.AreEqual(111, recipeCategoryModel.RecipeCategoryId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeCategoryName_SetValue_StoresCorrectly()
        {
            RecipeCategoryModel recipeCategoryModel = new RecipeCategoryModel {RecipeCategoryName = "A name"};
            Assert.AreEqual("A name", recipeCategoryModel.RecipeCategoryName);
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            RecipeCategoryModel recipeCategoryModel = new RecipeCategoryModel {ImagePath = @"C:\good\path"};
            Assert.AreEqual(@"C:\good\path", recipeCategoryModel.ImagePath);
        }
    }
}