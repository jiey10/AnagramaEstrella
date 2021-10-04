using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Oreintada a Servicios
Nombre del Maestro: Joel Ivan Chuc Uc
Nombre de la actividad: API ANAGRAMAS
Nombre del alumno o Alumnos: Jesus Ivan Estrella Yah
Cuatrimestre: 4to Cuatrimestre
Grupo: 4B
Parcial: 1er Parcial
 */

namespace AnagramaEstrella.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnagramaController : ControllerBase
    {
        [HttpGet]
        public IActionResult PalabrasAnagramas(string P1, string P2)
        {
            bool Anagrama;
            var Resultado = "";
            if (P1.Length != P2.Length)
            {
                Anagrama = false;
            }
            else
            {
                char[] L1 = P1.ToCharArray();
                Array.Sort(L1);
                char[] L2 = P2.ToCharArray();
                Array.Sort(L2);

                string PL = new string(L1);
                string PL2 = new string(L2);
                if (PL == PL2)
                {
                    Anagrama = true;
                }
                else
                {
                    Anagrama = false;
                }
            }
            if (Anagrama == true)
            {
                Resultado = "Las palabras " + P1 + " y " + P2 + " Son Anagramas";
            }
            else
            {
                Resultado = "Las palabras " + P1 + " y " + P2 + " No son Anagramas";
            }
            return Ok(Resultado);
        }
    }
}
