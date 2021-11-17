namespace sistema1_Back_Endv2.data
{
    public class Paciente
    {
        public int id { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string fechaNac { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }


        public Paciente(int _id) => this.id = _id;

        //Para inserccion de registro
        public Paciente(string aPaterno, string aMaterno, string nombre, string gene, string fechaNac, string correo, string contrasenia)
        {
            this.apellidoPaterno = aPaterno;
            this.apellidoMaterno = aMaterno;
            this.nombre = nombre;
            this.genero = gene;
            this.fechaNac = fechaNac;
            this.correo = correo;
            this.contrasenia = contrasenia;
        }

        //Para editar un registro
        public Paciente(int _id, string aPaterno, string aMaterno, string nombre, string gene, string fechaNac, string correo, string contrasenia)
        {
            this.id = _id;
            this.apellidoPaterno = aPaterno;
            this.apellidoMaterno = aMaterno;
            this.nombre = nombre;
            this.genero = gene;
            this.fechaNac = fechaNac;
            this.correo = correo;
            this.contrasenia = contrasenia;
        }


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

        //Apellido Paterno
        public string get_aPaterno()
        {
            return apellidoPaterno;
        }

        public void set_aPaterno(string aPaterno)
        {
            this.apellidoPaterno = aPaterno;
        }

        //Apellido Materno
        public string get_aMaterno()
        {
            return apellidoMaterno;
        }

        public void set_aMaterno(string aMaterno)
        {
            this.apellidoMaterno = aMaterno;
        }

        //Nombre
        public string getNombre()
        {
            return nombre;
        }

        public void setEdad(string nombre)
        {
            this.nombre = nombre;
        }

        //Genero
        public string getGenero()
        {
            return genero;
        }

        public void setGenero(string gen)
        {
            this.genero = gen;
        }

        //Fecha de nacimiento
        public string getFechaNac()
        {
            return fechaNac;
        }

        public void setFechaNac(string fechaNac)
        {
            this.fechaNac = fechaNac;
        }

        //Corre
        public string getCorreo()
        {
            return correo;
        }

        public void setCorreo(string correo)
        {
            this.correo = correo;
        }

        //Contraseña
        public string getContrasenia()
        {
            return contrasenia;

        }

        public void setContrasenia(string contrasenia) => this.contrasenia = contrasenia;

        //[Required]
        //public string Title { get; set; }

        //public DateTimeOffset? DueAt { get; set; }

    }
}
