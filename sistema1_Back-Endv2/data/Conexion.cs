using System.Data.SqlClient;
using System.Data;

namespace sistema1_Back_Endv2.data

{
    public class Conexion
    {
        //Es muy importante declararla como una constante, porque de otra fomra la rechaza el SqlConnection, debe ser estatico
        private const string stringConnection = "server=LAPTOP-E0ORA0CH;database=base_para_pruebas;Trusted_Connection=true";        

        SqlConnection conn = new SqlConnection(stringConnection);//Conexion                

        //Metodo que regresa la conexion
        public SqlConnection getConnection()
        {
            return conn;
        }

        //private static void CreateCommand(string queryString,
        //string connectionString)
        //{
        //    using (SqlConnection connection = new SqlConnection(
        //               connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(queryString, connection);
        //        command.Connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}

        //private static SqlConnection getConecction()
        //{
        //    return connection;
        //}
    }
}
