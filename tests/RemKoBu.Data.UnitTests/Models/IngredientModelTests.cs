using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class IngredientModelTests
    {
        [Test]
        public void PropertyIngredientId_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.ingredient_id = 5;
            Assert.AreEqual(5, ingredientModel.ingredient_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientsCategoryId_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.ingredientsCategory_id = 4;
            Assert.AreEqual(4, ingredientModel.ingredientsCategory_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyIngredientName_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.ingredient_name = "Eine leckere Zutat";
            Assert.AreEqual("Eine leckere Zutat", ingredientModel.ingredient_name);
        }

        [Test]
        public void PropertyKcalPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.kcal_per_100g = 111;
            Assert.AreEqual(111, ingredientModel.kcal_per_100g, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyChPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.ch_per_100g = 222;
            Assert.AreEqual(222, ingredientModel.ch_per_100g, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyPrPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.pr_per_100g = 333;
            Assert.AreEqual(333, ingredientModel.pr_per_100g, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyFatPer100g_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.fat_per_100g = 444;
            Assert.AreEqual(444, ingredientModel.fat_per_100g, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            IngredientModel ingredientModel = new IngredientModel();
            ingredientModel.image_path = @"C:\Windows\system32";
            Assert.AreEqual(@"C:\Windows\system32", ingredientModel.image_path);
        }
    }
}