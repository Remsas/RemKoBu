using NUnit.Framework;
using RemKoBu.Data.Models;

namespace RemKoBu.Data.UnitTests.Models
{
    public class RecipeModelTests
    {
        [Test]
        public void PropertyRecipeId_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.recipe_id = 111;
            Assert.AreEqual(111, recipeModel.recipe_id, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyRecipeName_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.recipe_name = "A name of a recipe";
            Assert.AreEqual("A name of a recipe", recipeModel.recipe_name);
        }

        [Test]
        public void PropertyPreparationTimeInMinutes_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.preperationtime_in_minutes = 222;
            Assert.AreEqual(222, recipeModel.preperationtime_in_minutes, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyMethod_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.method = "Step 1: Preheat your head \n" +
                                 "Step 2: Cook your mind \n" +
                                 "Step 3: Server your ideas";
            Assert.AreEqual("Step 1: Preheat your head \n" +
                                 "Step 2: Cook your mind \n" +
                                 "Step 3: Server your ideas", 
                                recipeModel.method);
        }

        [Test]
        public void PropertyRating_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.rating = 5;
            Assert.AreEqual(5, recipeModel.rating, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyCooked_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.cooked = 1;
            Assert.AreEqual(1, recipeModel.cooked, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyImagePath_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.image_path = @"C:\good\path";
            Assert.AreEqual(@"C:\good\path", recipeModel.image_path);
        }

        [Test]
        public void PropertyDifficultyLevel_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.difficulty_level = 7;
            Assert.AreEqual(7, recipeModel.difficulty_level, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyMarkedForCooking_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.marked_for_cooking = 0;
            Assert.AreEqual(0, recipeModel.marked_for_cooking, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyServingCount_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.serving_count = 4;
            Assert.AreEqual(4, recipeModel.serving_count, 0, "stores incorrectly");
        }

        [Test]
        public void PropertyServingType_SetValue_StoresCorrectly()
        {
            RecipeModel recipeModel = new RecipeModel();
            recipeModel.serving_type = "portions";
            Assert.AreEqual("portions", recipeModel.serving_type);
        }
    }
}