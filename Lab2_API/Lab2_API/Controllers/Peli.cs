using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab2_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Peli : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IComparable<string> Get(string id)
        {
            Peliculas pelic = new Peliculas();
            Nodo nodo = new Nodo(pelic);

            if (id == "Inorden" | id == "InOrden")
            {
                nodo.InOrden(nodo);
            }
            else if (id == "Preorden" | id == "PreOrden")
            {
                nodo.PreOrden(nodo);
            }
            else if (id == "Postorden" | id == "PostOrden")
            {
                nodo.PostOrden(nodo);
            }

            return "Done";
        }

        // POST api/<Movies>
        /*[HttpPost]
        [Route("/movies/populate")]
        public void Post([FromBody] string value)
        {
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                Movies product = JsonConvert.DeserializeObject<Product>(json);
            }
        }
        */

        //DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Peliculas pelicula = new Peliculas();
            Nodo nodo = new Nodo(pelicula);
            nodo.delete(id);


        }
    }
}
