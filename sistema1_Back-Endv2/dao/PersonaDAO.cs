using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema1_Back_Endv2.data;
using System.Data.SqlClient;//para poder trabjar con la base de datos
using System.Net;//Usar respuestas Http
using System.Web.Http;//Usar respuestas Http

namespace sistema1_Back_Endv2.dao
{
    public class PersonaDAO
    {
        Conexion conexion = new Conexion();
        string sql_insertar = "INSERT INTO PERSONAS VALUES (@nombre,@apellido,@edad)";
        //Objeto Persona

        public string insertarRegistro(Persona persona)
        {
            SqlConnection conn = null;
            SqlCommand stmt = null;            

                try{
                conn = conexion.getConnection();
                conn.Open();
                //stmt.Connection = conn;
                //stmt.CommandText=sql_insertar;
                stmt = new SqlCommand(sql_insertar, conn);
                stmt.Parameters.AddWithValue("@nombre", persona.getNombre());
                stmt.Parameters.AddWithValue("@apellido", persona.getApellido());
                stmt.Parameters.AddWithValue("@edad", persona.getEdad());
                stmt.ExecuteNonQuery();
                conn.Close();
                return "Inserccion Exitosta desde el DAO";


            }catch(Exception ex)
            {
                return ex.ToString();
                //throw new HttpResponseException(HttpStatusCode.NotFound);                
                throw new Exception("Outer", ex);//Detiene la app y muestra mensaje
                
            }

        }
        
        
        
    }
}
