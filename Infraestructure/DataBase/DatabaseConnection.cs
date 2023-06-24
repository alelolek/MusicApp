using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Infraestructure.DataBase
{
	public class DatabaseConnection 
	{
		private static DatabaseConnection instance;

		public SqlConnection GetConnection()
		{
			//var connection = ConfigurationManager.ConnectionStrings["SQLServerConnection"].ConnectionString;
			var connection = "Data Source=DESKTOP-1TL06GG\\SQLEXPRESS;Initial Catalog=DBMusicApp;Integrated Security=True";
			return new SqlConnection(connection);
		}

        public static DatabaseConnection GetInstance()
        {
			if (instance == null)
				instance = new DatabaseConnection();

			return instance;
        }
    }
}
