using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;
using RemKoBu.Core.DataAccess;
using RemKoBu.Data.Models;


namespace RemKoBu.Core.IntegrationTests
{
    public class WriteAndReadDataAndGetModelObjects
    {
        private const string ConnectionString = @"Data Source=.\remkobudb_test.db;";
        private readonly IDataAccess _sqlDataAccess = new SqliteDataAccess();
        
        [Test]
        public void TableIngredient_WriteData_ReadDataAndGetIngredientModelObject()
        {
            // Arrange
            IngredientModel ingredientModelInput = new IngredientModel
            {
                IngredientId = 111,
                IngredientCategoryId = 222,
                IngredientName = "An ingredient",
                KcalPer100G = 333,
                ChPer100G = 444,
                PrPer100G = 555,
                FatPer100G = 666,
                ImagePath = @"C:\path\to\heaven"
            };

            ObservableCollection<IngredientModel> ingredientModelsCollection = new ObservableCollection<IngredientModel>();

            const string sqlStatementSaveData = "INSERT INTO Ingredient (IngredientId, IngredientCategoryId, IngredientName, " +
                                                "KcalPer100G, ChPer100G, PrPer100G, FatPer100G, ImagePath)" +
                                                "VALUES (@IngredientId, @IngredientCategoryId, @IngredientName, " +
                                                "@KcalPer100G, @ChPer100G, @PrPer100G, @FatPer100G, @ImagePath)";
            const string sqlStatementLoadData = "SELECT * FROM Ingredient";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@IngredientId", ingredientModelInput.IngredientId},
                {"@IngredientCategoryId", ingredientModelInput.IngredientCategoryId},
                {"@IngredientName", ingredientModelInput.IngredientName},
                {"@KcalPer100G", ingredientModelInput.KcalPer100G},
                {"@ChPer100G", ingredientModelInput.ChPer100G},
                {"@PrPer100G", ingredientModelInput.PrPer100G},
                {"@FatPer100G", ingredientModelInput.FatPer100G},
                {"@ImagePath", ingredientModelInput.ImagePath}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<IngredientModel> ingredientModelsList = _sqlDataAccess.LoadData<IngredientModel>(sqlStatementLoadData,
                new Dictionary<string, object>(), ConnectionString);
            ingredientModelsList.ForEach(x => ingredientModelsCollection.Add(x));
            IngredientModel ingredientModelOutput = ingredientModelsCollection.First();

            // Assert
            Assert.AreEqual(111, ingredientModelOutput.IngredientId, 0, "wrong value in IngredientId");
            Assert.AreEqual(222, ingredientModelOutput.IngredientCategoryId, 0, "wrong value in IngredientCategoryId");
            Assert.AreEqual("An ingredient", ingredientModelOutput.IngredientName);
            Assert.AreEqual(333, ingredientModelOutput.KcalPer100G, 0, "wrong value in KcalPer100G");
            Assert.AreEqual(444, ingredientModelOutput.ChPer100G, 0, "wrong value in ChPer100G");
            Assert.AreEqual(555, ingredientModelOutput.PrPer100G, 0, "wrong value in PrPer100G");
            Assert.AreEqual(666, ingredientModelOutput.FatPer100G, 0, "wrong value in FatPer100G");
            Assert.AreEqual(@"C:\path\to\heaven", ingredientModelOutput.ImagePath);
        }

        [Test]
        public void TableIngredientCategory_WriteData_ReadDataAndGetIngredientCategoryModelObject()
        {
            // Arrange
            IngredientCategoryModel ingredientCategoryModelInput = new IngredientCategoryModel
            {
                IngredientCategoryId = 111,
                IngredientCategoryName = "A category name",
                ImagePath = @"C:\path\to\hell"
            };

            ObservableCollection<IngredientCategoryModel> ingredientCategoryModelsCollection = new ObservableCollection<IngredientCategoryModel>();

            const string sqlStatementSaveData = "INSERT INTO IngredientCategory (IngredientCategoryId, IngredientCategoryName, ImagePath)" +
                                                "VALUES (@IngredientCategoryId, @IngredientCategoryName, @ImagePath)";
            const string sqlStatementLoadData = "SELECT * FROM IngredientCategory";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@IngredientCategoryId", ingredientCategoryModelInput.IngredientCategoryId},
                {"@IngredientCategoryName", ingredientCategoryModelInput.IngredientCategoryName},
                {"@ImagePath", ingredientCategoryModelInput.ImagePath}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<IngredientCategoryModel> ingredientCategoryModelsList = _sqlDataAccess.LoadData<IngredientCategoryModel>(sqlStatementLoadData,
                new Dictionary<string, object>(), ConnectionString);
            ingredientCategoryModelsList.ForEach(x => ingredientCategoryModelsCollection.Add(x));
            IngredientCategoryModel ingredientCategoryModelOutput = ingredientCategoryModelsCollection.First();

            // Assert
            Assert.AreEqual(111, ingredientCategoryModelOutput.IngredientCategoryId, 0, "wrong value in IngredientCategoryId");
            Assert.AreEqual("A category name", ingredientCategoryModelOutput.IngredientCategoryName);
            Assert.AreEqual(@"C:\path\to\hell", ingredientCategoryModelOutput.ImagePath);
        }

        [Test]
        public void TableRecipe_WriteData_ReadDataAndGetRecipeModelObject()
        {
            // Arrange
            RecipeModel recipeModelInput = new RecipeModel
            {
                RecipeId = 111,
                RecipeName = "A recipe name",
                PreperationtimeInMinutes = 222,
                Method = "The steps to cook this recipe",
                Rating = 333,
                Cooked = 1,
                ImagePath = @"C:\path\to\glory",
                DifficultyLevel = 5,
                MarkedForCooking = 0,
                ServingAmount = 4,
                ServingType = "portions"
            };

            ObservableCollection<RecipeModel> recipeModelCollection = new ObservableCollection<RecipeModel>();

            const string sqlStatementSaveData = "INSERT INTO Recipe (RecipeId, RecipeName, " +
                                                "PreperationtimeInMinutes, Method, Rating, Cooked, ImagePath, " +
                                                "DifficultyLevel, MarkedForCooking, ServingAmount, ServingType) " +
                                                "VALUES (@RecipeId, @RecipeName, @PreperationtimeInMinutes, " +
                                                "@Method, @Rating, @Cooked, @ImagePath, @DifficultyLevel, " +
                                                "@MarkedForCooking, @ServingAmount, @ServingType)";
            const string sqlStatementLoadData = "SELECT * FROM Recipe";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@RecipeId", recipeModelInput.RecipeId},
                {"@RecipeName", recipeModelInput.RecipeName},
                {"@PreperationtimeInMinutes", recipeModelInput.PreperationtimeInMinutes},
                {"@Method", recipeModelInput.Method},
                {"@Rating", recipeModelInput.Rating},
                {"@Cooked", recipeModelInput.Cooked},
                {"@ImagePath", recipeModelInput.ImagePath},
                {"@DifficultyLevel", recipeModelInput.DifficultyLevel},
                {"@MarkedForCooking", recipeModelInput.MarkedForCooking},
                {"@ServingAmount", recipeModelInput.ServingAmount},
                {"@ServingType", recipeModelInput.ServingType}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<RecipeModel> recipeModelsList = _sqlDataAccess.LoadData<RecipeModel>(sqlStatementLoadData,
                new Dictionary<string, object>(), ConnectionString);
            recipeModelsList.ForEach(x => recipeModelCollection.Add(x));
            RecipeModel recipeModelOutput = recipeModelCollection.First();

            // Assert
            Assert.AreEqual(111, recipeModelOutput.RecipeId, 0, "wrong value in RecipeId");
            Assert.AreEqual("A recipe name", recipeModelOutput.RecipeName);
            Assert.AreEqual(222, recipeModelOutput.PreperationtimeInMinutes, 0, "wrong value in PreperationtimeInMinutes");
            Assert.AreEqual("The steps to cook this recipe", recipeModelOutput.Method);
            Assert.AreEqual(333, recipeModelOutput.Rating, 0, "wrong value in Rating");
            Assert.AreEqual(1, recipeModelOutput.Cooked, 0, "wrong value in Cooked");
            Assert.AreEqual(@"C:\path\to\glory", recipeModelOutput.ImagePath);
            Assert.AreEqual(5, recipeModelOutput.DifficultyLevel, 0, "wrong value in DifficultyLevel");
            Assert.AreEqual(0, recipeModelOutput.MarkedForCooking, 0, "wrong value in MarkedForCooking");
            Assert.AreEqual(4, recipeModelOutput.ServingAmount, 0, "wrong value in ServingAmount");
            Assert.AreEqual("portions", recipeModelOutput.ServingType);
        }

        [Test]
        public void TableRecipeCategory_WriteData_ReadDataAndGetRecipeCategoryModelObject()
        {
            // Arrange
            RecipeCategoryModel recipeCategoryModelInput = new RecipeCategoryModel
            {
                RecipeCategoryId = 111,
                RecipeCategoryName = "A category name",
                ImagePath = @"C:\path\to\infinity"
            };

            ObservableCollection<RecipeCategoryModel> recipeCategoryModelCollection = new ObservableCollection<RecipeCategoryModel>();

            const string sqlStatementSaveData = "INSERT INTO RecipeCategory (RecipeCategoryId, RecipeCategoryName, " +
                                                "ImagePath) " +
                                                "VALUES (@RecipeCategoryId, @RecipeCategoryName, @ImagePath)";
            const string sqlStatementLoadData = "SELECT * FROM RecipeCategory";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@RecipeCategoryId", recipeCategoryModelInput.RecipeCategoryId},
                {"@RecipeCategoryName", recipeCategoryModelInput.RecipeCategoryName},
                {"@ImagePath", recipeCategoryModelInput.ImagePath}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<RecipeCategoryModel> recipeCategoryModelList = _sqlDataAccess.LoadData<RecipeCategoryModel>(sqlStatementLoadData,
                new Dictionary<string, object>(), ConnectionString);
            recipeCategoryModelList.ForEach(x => recipeCategoryModelCollection.Add(x));
            RecipeCategoryModel recipeCategoryModelOutput = recipeCategoryModelCollection.First();

            // Assert
            Assert.AreEqual(111, recipeCategoryModelOutput.RecipeCategoryId, 0, "wrong value RecipeCategoryId");
            Assert.AreEqual("A category name", recipeCategoryModelOutput.RecipeCategoryName);
            Assert.AreEqual(@"C:\path\to\infinity", recipeCategoryModelOutput.ImagePath);
        }

        [Test]
        public void TableRecipeIngredient_WriteData_ReadDataAndGetRecipeIngredientModelObject()
        {
            // Arrange
            RecipeIngredientModel recipeIngredientModelInput = new RecipeIngredientModel
            {
                RecipeIngredientId = 111,
                RecipeId = 222,
                IngredientId = 333,
                IngredientQuantity = 444,
                IngredientMeasureUnit = "a measure unit",
                GrammPerIngredientMeasureUnit = 555
            };

            ObservableCollection<RecipeIngredientModel> recipeIngredientModelCollection =
                new ObservableCollection<RecipeIngredientModel>();

            const string sqlStatementSaveData =
                "INSERT INTO RecipeIngredient (RecipeIngredientId, RecipeId, IngredientId, IngredientQuantity, IngredientMeasureUnit, GrammPerIngredientMeasureUnit) " +
                "VALUES (@RecipeIngredientId, @RecipeId, @IngredientId, @IngredientQuantity, @IngredientMeasureUnit, @GrammPerIngredientMeasureUnit)";
            const string sqlStatementLoadData = "SELECT * FROM RecipeIngredient";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@RecipeIngredientId", recipeIngredientModelInput.RecipeIngredientId},
                {"@RecipeId", recipeIngredientModelInput.RecipeId},
                {"@IngredientId", recipeIngredientModelInput.IngredientId},
                {"@IngredientQuantity", recipeIngredientModelInput.IngredientQuantity},
                {"@IngredientMeasureUnit", recipeIngredientModelInput.IngredientMeasureUnit},
                {"@GrammPerIngredientMeasureUnit", recipeIngredientModelInput.GrammPerIngredientMeasureUnit}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<RecipeIngredientModel> recipeIngredientModelList = _sqlDataAccess.LoadData<RecipeIngredientModel>(sqlStatementLoadData, new Dictionary<string, object>(), ConnectionString);
            recipeIngredientModelList.ForEach(x => recipeIngredientModelCollection.Add(x));
            RecipeIngredientModel recipeIngredientModelOutput = recipeIngredientModelCollection.First();

            // Assert
            Assert.AreEqual(111, recipeIngredientModelOutput.RecipeIngredientId, 0, "wrong value in RecipeIngredientId");
            Assert.AreEqual(222, recipeIngredientModelOutput.RecipeId, 0, "wrong value in RecipeId");
            Assert.AreEqual(333, recipeIngredientModelOutput.IngredientId, 0, "wrong value in IngredientId");
            Assert.AreEqual(444, recipeIngredientModelOutput.IngredientQuantity, 0, "wrong value in IngredientQuantity");
            Assert.AreEqual("a measure unit", recipeIngredientModelOutput.IngredientMeasureUnit);
            Assert.AreEqual(555, recipeIngredientModelOutput.GrammPerIngredientMeasureUnit, 0, "wrong value in GrammPerIngredientMeasureUnit");
        }

        [Test]
        public void TableRecipeRecipeCategory_WriteData_ReadDataAndGetRecipeIngredientModelObject()
        {
            // Arrange
            RecipeRecipeCategoryModel rrcmInput = new RecipeRecipeCategoryModel
            {
                RecipeRecipeCategoryId = 111,
                RecipeId = 222,
                RecipeCategoryId = 333
            };

            ObservableCollection<RecipeRecipeCategoryModel> rrcmCollection =
                new ObservableCollection<RecipeRecipeCategoryModel>();

            const string sqlStatementSaveData = "INSERT INTO RecipeRecipeCategory (RecipeRecipeCategoryId, RecipeId, RecipeCategoryId) " +
                                                "VALUES (@RecipeRecipeCategoryId, @RecipeId, @RecipeCategoryId)";
            const string sqlStatementLoadData = "SELECT * FROM RecipeRecipeCategory";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@RecipeRecipeCategoryId", rrcmInput.RecipeRecipeCategoryId},
                {"@RecipeId", rrcmInput.RecipeId},
                {"@RecipeCategoryId", rrcmInput.RecipeCategoryId}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<RecipeRecipeCategoryModel> rrcmList = _sqlDataAccess.LoadData<RecipeRecipeCategoryModel>(sqlStatementLoadData, new Dictionary<string, object>(), ConnectionString);
            rrcmList.ForEach(x => rrcmCollection.Add(x));
            RecipeRecipeCategoryModel rrcmOutput = rrcmCollection.First();

            // Assert
            Assert.AreEqual(111, rrcmOutput.RecipeRecipeCategoryId, 0, "wrong value in RecipeRecipeCategoryId");
            Assert.AreEqual(222, rrcmOutput.RecipeId, 0, "wrong value in RecipeId");
            Assert.AreEqual(333, rrcmOutput.RecipeCategoryId, 0, "wrong value in RecipeCategoryId");
        }

        [Test]
        public void TableRecipeSpice_WriteData_ReadDataAndGetRecipeSpiceModelObject()
        {
            // Arrange
            RecipeSpiceModel rsmInput = new RecipeSpiceModel
            {
                RecipeSpiceId = 111,
                RecipeId = 222,
                SpiceId = 333,
                SpiceQuantity = 444,
                SpiceMeasureUnit = "a measure unit"
            };

            ObservableCollection<RecipeSpiceModel> rsmCollection = new ObservableCollection<RecipeSpiceModel>();

            const string sqlStatementSaveData = "INSERT INTO RecipeSpice (RecipeSpiceId, RecipeId, SpiceId, SpiceQuantity, SpiceMeasureUnit) " +
                                                "VALUES (@RecipeSpiceId, @RecipeId, @SpiceId, @SpiceQuantity, @SpiceMeasureUnit)";
            const string sqlStatementLoadData = "SELECT * FROM RecipeSpice";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@RecipeSpiceId", rsmInput.RecipeSpiceId},
                {"@RecipeId", rsmInput.RecipeId},
                {"@SpiceId", rsmInput.SpiceId},
                {"@SpiceQuantity", rsmInput.SpiceQuantity},
                {"@SpiceMeasureUnit", rsmInput.SpiceMeasureUnit}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<RecipeSpiceModel> rsmList = _sqlDataAccess.LoadData<RecipeSpiceModel>(sqlStatementLoadData, new Dictionary<string, object>(), ConnectionString);
            rsmList.ForEach(x => rsmCollection.Add(x));
            RecipeSpiceModel rsmOutput = rsmCollection.First();

            // Assert
            Assert.AreEqual(111, rsmOutput.RecipeSpiceId, 0, "wrong value in RecipeSpiceId");
            Assert.AreEqual(222, rsmOutput.RecipeId, 0, "wrong value in RecipeId");
            Assert.AreEqual(333, rsmOutput.SpiceId, 0, "wrong value in SpiceId");
            Assert.AreEqual(444, rsmOutput.SpiceQuantity, 0, "wrong value in SpiceQuantity");
            Assert.AreEqual("a measure unit", rsmOutput.SpiceMeasureUnit);
        }

        [Test]
        public void TableSpice_WriteData_ReadDataAndGetSpiceModelObject()
        {
            // Arrange
            SpiceModel smInput = new SpiceModel
            {
                SpiceId = 111,
                SpiceName = "a spice name",
                ImagePath = @"c:\path\to\spicy"
            };

            ObservableCollection<SpiceModel> smCollection = new ObservableCollection<SpiceModel>();

            const string sqlStatementSaveData = "INSERT INTO Spice (SpiceId, SpiceName, ImagePath) " +
                                                "VALUES (@SpiceId, @SpiceName, @ImagePath)";
            const string sqlStatementLoadData = "SELECT * FROM Spice";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@SpiceId", smInput.SpiceId},
                {"@SpiceName", smInput.SpiceName},
                {"@ImagePath", smInput.ImagePath}
            };

            // Act
            _sqlDataAccess.SaveData(sqlStatementSaveData, parameters, ConnectionString);
            List<SpiceModel> smList = _sqlDataAccess.LoadData<SpiceModel>(sqlStatementLoadData, new Dictionary<string, object>(), ConnectionString);
            smList.ForEach(x => smCollection.Add(x));
            SpiceModel smOutput = smCollection.First();

            // Assert
            Assert.AreEqual(111, smOutput.SpiceId, 0, "wrong value in SpiceId");
            Assert.AreEqual("a spice name", smOutput.SpiceName);
            Assert.AreEqual(@"c:\path\to\spicy", smOutput.ImagePath);
        }
    }
}