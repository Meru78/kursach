using MySqlConnector;
namespace kursach.DBManager
{
    public class DBManager
    {
        public static string connStr;
        public static MySqlConnection GetConnection() {
            try
            {
                MySqlConnection mySqlConnection = new (connStr);
                return mySqlConnection;
            }
            catch(Exception e) { 
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
