using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema1_Back_Endv2.dao;
using sistema1_Back_Endv2.data;

namespace sistema1_Back_Endv2.Controllers
{
    
    [ApiController]//Necesario pare reconocer una clase como Controlador
    
    public class PersonaController : ControllerBase //Necesario para asignarlo como controlador ; no maneja vistas
    {

        //Creacion de objeto dao        
        private PersonaDAO personaDao = new();


        //Insertar datos por medio de Get; Valores Estaticos
        [HttpPost]
        [Route("[controller]")]//Ruta || Endpoint
        public IActionResult InsertarPersona([FromBody]  Persona _persona)//[FromBody] : Para recibir objetos JSON 
        {
            string nombre = _persona.getNombre();
            string apellido = _persona.getApellido();
            int edad = _persona.getEdad();
            //Persona persona = new("Claudette", "Cruz", 22);
            Persona persona = new(nombre,apellido,edad);
            //return Ok(persona);
            try
            {
                //Insert
                string res = personaDao.insertarRegistro(persona);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }
        //[HttpGet]
        //[Route("[controller]")]//Ruta || Endpoint
        //public IActionResult InsertarPersona(Persona persona)
        //{
        //    Persona persona = new("Claudette", "Cruz", 22);
        //    try
        //    {
        //        string res = personaDao.insertarRegistro(persona);                
        //        return Ok(res);                
        //    }catch(Exception ex)
        //    {
        //        return NotFound(ex);
        //    }           

        //}


        //[HttpGet]
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;        
        //[Route("[controller]")]//Ruta || Endpoint
        //public IActionResult Welcome(string name, int numTimes = 1)//IActionResult Necesario
        //{
        //    return Ok("Holaaa"); 
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //Mostrar Registros
        [HttpGet]
        [Route("[controller]/mostrar")]//Ruta || Endpoint
        public IActionResult mostrarPesonas() // Or List<Persona> mostrarPersonas()
        {
            List<Persona> personas = personaDao.mostrarPersonas();

            return Ok(personas);//Regresa un arreglo de objetos
            //return Ok("TOdo bien");
            
            
        }

        //Mostrar Single Person
        [HttpGet]
        [Route("[controller]/persona")]//Ruta || Endpoint
        public IActionResult showSinglePerson()
        {
            Persona persona = personaDao.GetSinglePerson();

            //personas.ForEach((persona) => return Ok(persona));         
            return Ok(persona);
        }



    }
}
