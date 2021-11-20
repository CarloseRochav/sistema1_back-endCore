using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema1_Back_Endv2.data;
using System.Data.SqlClient;//para poder trabjar con la base de datos
using System.Net;//Usar respuestas Http
using System.Web.Http;//Usar respuestas Http
using System.Data;//Para poder usar DataSet

namespace sistema1_Back_Endv2.dao
{
    public class PersonaDAO
    {
        Conexion conexion = new Conexion();
        string sql_insertar = "INSERT INTO PERSONAS VALUES (@nombre,@apellido,@edad)";
        string sql_consultar = "SELECT * FROM PERSONAS ";
        //Objeto Persona

        //Insertar Registro
        public string insertarRegistro(Persona persona)
        {
            SqlConnection conn = null;
            SqlCommand stmt = null;

            try {
                conn = conexion.getConnection();
                conn.Open();
                stmt = new SqlCommand(sql_insertar, conn);
                stmt.Parameters.AddWithValue("@nombre", persona.getNombre());
                stmt.Parameters.AddWithValue("@apellido", persona.getApellido());
                stmt.Parameters.AddWithValue("@edad", persona.getEdad());
                stmt.ExecuteNonQuery();
                conn.Close();
                return "Inserccion Exitosta desde el DAO";


            } catch (Exception ex)
            {
                return ex.ToString();
                //throw new HttpResponseException(HttpStatusCode.NotFound);                
                //throw new Exception("Outer", ex);//Detiene la app y muestra mensaje                
            }
        }

        //Mostrar Personas
        public List<Persona> mostrarPersonas()
        {

            List<Persona> personas = new List<Persona>();//Correcto        
            SqlConnection conn = null;
            SqlCommand stmt = null;
            //Create a SqlDataAdapter for the Suppliers table.
            //SqlDataAdapter adapter = new SqlDataAdapter();
            // Fill the DataSet.
            //DataSet dataSet = new DataSet("Suppliers");
            //DataSet dataSet = null;
            //SqlDataReader ; para guardar los valores que recibes de 
            SqlDataReader reader = null;
            DataTable result = new();
            Persona persona = null;


            try
            {
                conn = conexion.getConnection();
                conn.Open();
                stmt = new SqlCommand(sql_consultar, conn);
                reader = stmt.ExecuteReader();
                result.Load(reader);

                foreach (DataRow row in result.Rows)
                {
                    int id = (int)row["ID"];
                    string nombre  = Convert.ToString(row["NOMBRE"]);
                    string apellido  = Convert.ToString(row["APELLIDO"]);
                    int edad = Convert.ToInt16(row["EDAD"]);

                    persona = new(id, nombre, apellido, edad);
                    personas.Add(persona);

                }

                conn.Close();//Cerramos la conexion


                //stmt.ExecuteNonQuery();
                //Adapter
                //adapter.SelectCommand=stmt;
                //dataSet = new("Personas");//Indicar table
                //adapter.Fill(dataSet);

                //Recorrer 

                conn.Close();
                

            }catch(Exception ex)
            {
               persona = new( ex.ToString(), null, 1);
            }
            
            return personas;
        }

        //Mostrar single Persona
        public Persona GetSinglePerson()
        {

            
            SqlConnection conn = null;
            SqlCommand stmt = null;            
            SqlDataReader reader = null;
            DataTable result = new();
            Persona persona = null;


            try
            {
                conn = conexion.getConnection();
                conn.Open();
                stmt = new SqlCommand(sql_consultar, conn);
                reader = stmt.ExecuteReader();
                result.Load(reader);

                foreach (DataRow row in result.Rows)
                {
                    int id = (int)row["ID"];
                    string nombre = Convert.ToString(row["NOMBRE"]);
                    string apellido = Convert.ToString(row["APELLIDO"]);
                    int edad = Convert.ToInt16(row["EDAD"]);

                    persona = new(id, nombre, apellido, edad);                   

                }

                conn.Close();//Cerramos la conexion         


            }
            catch (Exception ex)
            {
                persona = new(ex.ToString(), null, 1);
            }

            return persona;
        }
    }  
        
        
    
}
