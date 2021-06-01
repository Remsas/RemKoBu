using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;

namespace RemKoBu.Core.DataAccess
{
    public class SqliteDataAccess : IDataAccess
    {
        public List<T> LoadData<T>(string sqlStatement, Dictionary<string, object> parameters,
            string connectionName)
        {
            DynamicParameters p = ToDynamicParameters(parameters);

            using (IDbConnection cnn = new SqliteConnection(connectionName))
            {
                var rows = cnn.Query<T>(sqlStatement, p);
                return rows.ToList();
            }
        }

        public void SaveData(string sqlStatement, Dictionary<string, object> parameters, string connectionName)
        {
            DynamicParameters p = ToDynamicParameters(parameters);

            using (IDbConnection cnn = new SqliteConnection(connectionName))
            {
                cnn.Execute(sqlStatement, p);
            }
        }
        
        private DynamicParameters ToDynamicParameters(Dictionary<string, object> p)
        {
            DynamicParameters output = new DynamicParameters();

            p.ToList().ForEach(x => output.Add(x.Key, x.Value));

            return output;
        }
    }
}