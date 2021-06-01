using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeModelTests
    {
        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {RecipeId = 111};
            Assert.AreEqual(111, recipeModel.RecipeId, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeName_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {RecipeName = "A name of a recipe"};
            Assert.AreEqual("A name of a recipe", recipeModel.RecipeName);
        }

        [Test]
        public void PropertyPreparationTimeInMinutes_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {PreperationtimeInMinutes = 222};
            Assert.AreEqual(222, recipeModel.PreperationtimeInMinutes, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyMethod_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel
            {
                Method = "Step 1: Preheat your head \n" +
                         "Step 2: Cook your mind \n" +
                         "Step 3: Server your ideas"
            };
            Assert.AreEqual("Step 1: Preheat your head \n" +
                            "Step 2: Cook your mind \n" +
                            "Step 3: Server your ideas", 
                                recipeModel.Method);
        }

        [Test]
        public void PropertyRating_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {Rating = 5};
            Assert.AreEqual(5, recipeModel.Rating, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyCooked_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {Cooked = 1};
            Assert.AreEqual(1, recipeModel.Cooked, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {ImagePath = @"C:\good\path"};
            Assert.AreEqual(@"C:\good\path", recipeModel.ImagePath);
        }

        [Test]
        public void PropertyDifficultyLevel_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {DifficultyLevel = 7};
            Assert.AreEqual(7, recipeModel.DifficultyLevel, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyMarkedForCooking_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {MarkedForCooking = 0};
            Assert.AreEqual(0, recipeModel.MarkedForCooking, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyServingCount_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {ServingAmount = 4};
            Assert.AreEqual(4, recipeModel.ServingAmount, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyServingType_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel {ServingType = "portions"};
            Assert.AreEqual("portions", recipeModel.ServingType);
        }
    }
}