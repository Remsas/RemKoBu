using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            string sqlStatement = "INSERT INTO spice (spice_name, image_path) " +
                                  "VALUES (@spice_name, @image_path)";
            string connectionString = @"Data Source=.\remkobudb_test.db;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@spice_name", "Pfeffer"},
                {"@image_path", @"der\pfad\zum\glueck"}
            };
            string expected = "Pfeffer";
            // Act
            SqliteDataAccess.SaveData(sqlStatement, parameters,connectionString);
            string actual = ReadPfefferFromDatabaseInTableSpice();
            // Assert
            StringAssert.AreEqualIgnoringCase(expected, actual);
        }

        [Test]
        public void LoadData_LoadSpice_FindSpecificSpiceName()
        {
            // Arrange
            ObservableCollection<SpiceModel> spices = new ObservableCollection<SpiceModel>();
            string connectionString = @"Data Source=.\remkobudb_test.db;";
            string sqlStatement = "SELECT spice_name FROM spice WHERE spice_name = 'Salz'";
            AddSalzToDatabaseInTableSpice();
            // Act
            var spiceList =
                SqliteDataAccess.LoadData<SpiceModel>(sqlStatement, new Dictionary<string, object>(), connectionString);
            string actual = spiceList[0].spice_name;
            // Assert
            StringAssert.AreEqualIgnoringCase("Salz", actual);
        }
        
        private string ReadPfefferFromDatabaseInTableSpice()
        {
            string output = "";

            using (var connection = new SqliteConnection(@"Data Source=.\remkobudb_test.db;"))
            {
                SpiceModel spice = new SpiceModel();
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"SELECT spice_name FROM spice WHERE spice_name = $spice_name";
                command.Parameters.AddWithValue("$spice_name", "Pfeffer");
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spiceName = reader.GetString(0);
                        output = spiceName;
                    }
                }
            }

            return output;
        }

        private void AddSalzToDatabaseInTableSpice()
        {
            string sqlStatement = "INSERT INTO spice (spice_name, image_path) " +
                                  "VALUES (@spice_name, @image_path)";
            string connectionString = @"Data Source=.\remkobudb_test.db;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@spice_name", "Salz"},
                {"@image_path", @"der\pfad\zum\glueck"}
            };
            SqliteDataAccess.SaveData(sqlStatement, parameters, connectionString);
        }
    }
}