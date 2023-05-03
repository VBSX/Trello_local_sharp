using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Trello_local_sharp.database_handle
{
    internal class database_get
    {
        private readonly SqliteConnection connection;

        public database_get()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var dbFilePath = baseDir + "database_handle\\database.db";
            
            
            var connectionStringBuilder = new SqliteConnectionStringBuilder
            {
                DataSource = dbFilePath
            };

            // Cria uma nova conexão
            connection = new SqliteConnection(connectionStringBuilder.ConnectionString);
            

        }

        public List<List<string>> GetItemsOfList(string statusColumn)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT id, title, description, status_id FROM tbl_tasks WHERE active_status = 'active' AND status_id = '{statusColumn}'";

            var items = new List<List<string>>(); 
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var itemInfo = new List<string>();
                //itemInfo.Add(reader.GetInt32(0).ToString());
                itemInfo.Add(reader.GetString(1));
                itemInfo.Add(reader.GetString(2));
                //itemInfo.Add(reader.GetString(3));
                items.Add(itemInfo);
            }
            return items;
        }
    }
}

