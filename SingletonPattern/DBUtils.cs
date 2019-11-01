using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class DBUtils
    {
  
        private static DBUtils _cnn = null;
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=127.0.0.1;database=soa;User id=sa1;Password=sa1;");

        private DBUtils()
        {
        }

        public static DBUtils getConnection()
        {
            if (_cnn== null)
            {
                _cnn = new DBUtils();
            }
            return _cnn;
        }

        public SqlConnection GetDBConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Not connected : " + e.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("End..");
                // Console.WriteLine("Not connected : " + e.ToString());
                Console.ReadLine();
            }
            Console.ReadLine();
            return con;
        }
    }
}
