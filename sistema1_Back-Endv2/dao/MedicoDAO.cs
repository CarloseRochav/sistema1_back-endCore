using System.Data.SqlClient;
using sistema1_Back_Endv2.data;

namespace sistema1_Back_Endv2.dao

{
    public class MedicoDAO
    {
        //Sentencias SQL Constantes
        private const string sql_consultar = "SELECT * FROM PERSONAS"; //Cuidar bien la sintatix de sql
        private const string sql_insertar = "INSERT INTO PERSONAS VALUES(?,?,?)";//INSERCCION DE VALORES
        private const string sql_actualizar = "UPDATE PERSONAS SET NOMBRE =?, APELLIDO = ?, EDAD=? WHERE ID=?";
        private const string sql_eliminar = "DELETE FROM PERSONAS WHERE ID=?";

        Conexion conn = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlConnection conex = null;  


        //Funcionando ; falta revision
        public void InsertarRegistro()
        {            
            conex = conn.getConnection();
            conex.Open();//Abrir la conexion
            comando.Connection = conex;
            comando.CommandText = "SELECT * FROM PERSONAS";
            //comando.
            conex.Close();//Cerrar conexion
        }
        
       

    }
}
