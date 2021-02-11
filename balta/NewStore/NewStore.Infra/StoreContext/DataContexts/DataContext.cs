using System;
using System.Data;
using MySql.Data.MySqlClient;
using NewStore.Shared;

namespace NewStore.Infra.StoreContext.DataContexts
{
    public class DataContext : IDisposable
    {
        public MySqlConnection Connection { get; set; }

        public DataContext()
        {
            Connection = new MySqlConnection(Settings.MySQLConnectionString);
            Connection.Open();
        }

        public void Dispose()
        { 
            if(Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}