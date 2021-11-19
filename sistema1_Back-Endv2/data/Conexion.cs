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
    }
}
