using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema1_Back_Endv2.dao;
using sistema1_Back_Endv2.data;

namespace sistema1_Back_Endv2.Controllers
{
    
    [ApiController]//Necesario para poder la clase como controlador
    
    public class PersonaController : ControllerBase
    {

        //Creacion de objeto dao
        //private PersonaDAO personaDao;//error, esta nulo
        private PersonaDAO personaDao = new();
        

        //Constructor / Controlador
        //public PersonaController(PersonaDAO personaDao)
        //{
        //    persona = personaDao;
        //}

      //  Insertar datos por medio de Get; Valores Estaticos

       [HttpGet]
        [Route("[controller]")]//Ruta || Endpoint
        public IActionResult InsertarPersona()
        {
            Persona persona = new("Claudette", "Cruz", 22);
            try
            {
                string res = personaDao.insertarRegistro(persona);                
                return Ok(res);                
            }catch(Exception ex)
            {
                return NotFound(ex);
            }
            //return Ok("Ruta conectada - ¿Insercion? " + persona.getNombre());

        }


        //[HttpGet]
        //// GET: /HelloWorld/Welcome/ 
        //// Requires using System.Text.Encodings.Web;
        ////[Route("[controller]")]//Ruta || Endpoint
        //[Route("[controller]")]//Ruta || Endpoint
        //public IActionResult Welcome(string name, int numTimes = 1)//IActionResult Necesario
        //{
        //    return Ok("Holaaa"); 
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}
    
     
    }
}
