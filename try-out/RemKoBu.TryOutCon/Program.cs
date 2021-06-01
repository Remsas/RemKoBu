using System;
using System.Collections.Generic;
using RemKoBu.Core.DataAccess;
using RemKoBu.Data.Models;

namespace RemKoBu.TryOutCon
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Data Source=.\remkobudb.db;";

            // In die Datenbank speichern
            string sql = "INSERT INTO spice (SpiceName, ImagePath) " +
                         "VALUES (@SpiceName, @ImagePath)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@SpiceName", "Pfeffer"},
                {"@ImagePath", @"der\pfad\zum\glueck"}
            };

            IDataAccess sqliteDataAccess = new SqliteDataAccess();
            sqliteDataAccess.SaveData(sql, parameters, connectionString);


            // Aus der Datenbank lesen
            sql = "SELECT * FROM spice ORDER BY SpiceName COLLATE NOCASE ASC";
            sqliteDataAccess = new SqliteDataAccess();
            var spiceList =
                sqliteDataAccess.LoadData<SpiceModel>(sql, new Dictionary<string, object>(), connectionString);
            spiceList.ForEach(x => Console.WriteLine(x.SpiceId + " " + x.SpiceName + " " + x.ImagePath));




            Console.ReadLine();
        }
    }
}
