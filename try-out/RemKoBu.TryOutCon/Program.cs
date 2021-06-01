using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using RemKoBu.Data;
using RemKoBu.Core;
using RemKoBu.Core.DataAccess;
using RemKoBu.Data.Models;

namespace RemKoBu.TryOutCon
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=.\remkobudb.db;";

            // In die Datenbank speichern
            string sql = "INSERT INTO spice (spice_name, image_path) " +
                         "VALUES (@spice_name, @image_path)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@spice_name", "Pfeffer"},
                {"@image_path", @"der\pfad\zum\glueck"}
            };

            IDataAccess sqliteDataAccess = new SqliteDataAccess();
            sqliteDataAccess.SaveData(sql, parameters, connectionString);


            // Aus der Datenbank lesen
            ObservableCollection<SpiceModel> spices = new ObservableCollection<SpiceModel>();

            sql = "SELECT * FROM spice ORDER BY spice_name COLLATE NOCASE ASC";
            sqliteDataAccess = new SqliteDataAccess();
            var spiceList =
                sqliteDataAccess.LoadData<SpiceModel>(sql, new Dictionary<string, object>(), connectionString);
            spiceList.ForEach(x => Console.WriteLine(x.spice_id + " " + x.spice_name + " " + x.image_path));




            Console.ReadLine();
        }
    }
}
