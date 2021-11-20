using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema1_Back_Endv2.data
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }


        //número como llave principal, apellido paterno, apellido materno, 
        //nombre, especialidad, género, fecha de nacimiento, correo electrónico y contraseña

        //Sobrecarga de constructor

        //Para consultar por medio de ID ; object
        public Persona(int _id) => this.id = _id;

        //Para inserccion de registro
        public Persona(string nombre, string apellido, int edad)
        {

            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        //Para editar un registro
        public Persona(int id, string nombre, string apellido, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        //Constructor con 0 Parametros
        public Persona() { }


        //Si queremos actualizas un atributo individual del registro
        //Metodos getters and setters
        public int getID()
        {
            return id;
        }

        public void setID(int ID)
        {
            this.id = ID;
        }

        //Nombre
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        //Apellido
        public string getApellido()
        {
            return apellido;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        //Edad
        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad =edad;
        }       
        

    }
}
