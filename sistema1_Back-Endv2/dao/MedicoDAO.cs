using System.Data.SqlClient;

namespace sistema1_Back_Endv2.dao

{
    public class MedicoDAO
    {
        //Sentencias SQL Constantes
        private const string sql_consultar = "SELECT * FROM PERSONAS"; //Cuidar bien la sintatix de sql
        private const string sql_insertar = "INSERT INTO PERSONAS VALUES(?,?,?)";//INSERCCION DE VALORES
        private const string sql_actualizar = "UPDATE PERSONAS SET NOMBRE =?, APELLIDO = ?, EDAD=? WHERE ID=?";
        private const string sql_eliminar = "DELETE FROM PERSONAS WHERE ID=?";

        //variable de conexion
        SqlConnection connection = null;

    }
}
