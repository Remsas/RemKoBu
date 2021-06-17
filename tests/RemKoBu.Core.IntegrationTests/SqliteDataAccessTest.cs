using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using NUnit.Framework;
using RemKoBu.Core.DataAccess;
using RemKoBu.Data.Models;

namespace RemKoBu.Core.UnitTests
{
    public class SqliteDataAccessTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SaveData_InsertSpice_SpiceReadable()
        {
            // Arrange
            const string sqlStatement = "INSERT INTO spice (SpiceName, ImagePath) " +
                                  "VALUES (@SpiceName, @ImagePath)";
            const string connectionString = @"Data Source=.\remkobudb_test.db;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@SpiceName", "Pfeffer"},
                {"@ImagePath", @"der\pfad\zum\glueck"}
            };
            const string expected = "Pfeffer";
            IDataAccess sqliteDataAccess = new SqliteDataAccess();
            // Act
            sqliteDataAccess.SaveData(sqlStatement, parameters,connectionString);
            string actual = ReadPfefferFromDatabaseInTableSpice();
            // Assert
            StringAssert.AreEqualIgnoringCase(expected, actual);
        }

        [Test]
        public void LoadData_LoadSpice_FindSpecificSpiceName()
        {
            // Arrange
            const string connectionString = @"Data Source=.\remkobudb_test.db;";
            const string sqlStatement = "SELECT SpiceName FROM spice WHERE SpiceName = 'Salz'";
            AddSalzToDatabaseInTableSpice();
            IDataAccess sqliteDataAccess = new SqliteDataAccess();
            // Act
            var spiceList =
                sqliteDataAccess.LoadData<SpiceModel>(sqlStatement, new Dictionary<string, object>(), connectionString);
            string actual = spiceList[0].SpiceName;
            // Assert
            StringAssert.AreEqualIgnoringCase("Salz", actual);
        }
        
        private static string ReadPfefferFromDatabaseInTableSpice()
        {
            string output = "";

            using var connection = new SqliteConnection(@"Data Source=.\remkobudb_test.db;");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"SELECT SpiceName FROM spice WHERE SpiceName = $SpiceName";
            command.Parameters.AddWithValue("$SpiceName", "Pfeffer");
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var spiceName = reader.GetString(0);
                output = spiceName;
            }

            return output;
        }

        private static void AddSalzToDatabaseInTableSpice()
        {
            const string sqlStatement = "INSERT INTO spice (SpiceName, ImagePath) " +
                                        "VALUES (@SpiceName, @ImagePath)";
            const string connectionString = @"Data Source=.\remkobudb_test.db;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@SpiceName", "Salz"},
                {"@ImagePath", @"der\pfad\zum\glueck"}
            };
            IDataAccess sqliteDataAccess = new SqliteDataAccess();
            sqliteDataAccess.SaveData(sqlStatement, parameters, connectionString);
        }
    }
}