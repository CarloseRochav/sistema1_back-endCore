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

        }


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
    
     
    }
}
