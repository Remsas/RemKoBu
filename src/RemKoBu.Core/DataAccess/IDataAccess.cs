using System.Collections.Generic;

namespace RemKoBu.Core.DataAccess
{
    public interface IDataAccess
    {
        List<T> LoadData<T>(string sqlStatement, Dictionary<string, object> parameters, string connectionName);
        void SaveData(string sqlStatement, Dictionary<string, object> parameters, string connectionName);
    }
}