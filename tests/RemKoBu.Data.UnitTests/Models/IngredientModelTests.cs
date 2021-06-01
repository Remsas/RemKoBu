using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class IngredientModelTests
    {
        [Test]
        public void PropertyIngredientId_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {IngredientId = 5};
            Assert.AreEqual(5, ingredientModel.IngredientId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientsCategoryId_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {IngredientCategoryId = 4};
            Assert.AreEqual(4, ingredientModel.IngredientCategoryId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientName_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {IngredientName = "Eine leckere Zutat"};
            Assert.AreEqual("Eine leckere Zutat", ingredientModel.IngredientName);
        }

        [Test]
        public void PropertyKcalPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {KcalPer100G = 111};
            Assert.AreEqual(111, ingredientModel.KcalPer100G, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyChPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {ChPer100G = 222};
            Assert.AreEqual(222, ingredientModel.ChPer100G, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyPrPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {PrPer100G = 333};
            Assert.AreEqual(333, ingredientModel.PrPer100G, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyFatPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {FatPer100G = 444};
            Assert.AreEqual(444, ingredientModel.FatPer100G, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel {ImagePath = @"C:\Windows\system32"};
            Assert.AreEqual(@"C:\Windows\system32", ingredientModel.ImagePath);
        }
    }
}