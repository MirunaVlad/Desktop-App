using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Desktop_App.Repository
{
    class Database
    {

        private static MySqlConnection Connection;

        public MySqlConnection GetConnection () { return Connection; }

        public void ConnectToDatabase ()
        {
			try
			{
				String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=yoga;";
				//String connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
				Connection = new MySqlConnection(connectionString);
				Connection.Open();
			}
			catch (Exception ex)
			{
				Console.Write(ex);
			}
		}

		public void disconnectFromDatabase()
		{
			try
			{
				Connection.Close();
			}
			catch (Exception ex)
			{
				Console.Write(ex);
			}
		}
	}
}
