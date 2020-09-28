using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.IO

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab2_API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        
        // GET: api/<Movies>
        [HttpGet]
        [Route("{id}")]
        public IComparable<string> Get(string id)
        {
            Pelicula movie = new Pelicula();
            Nodo nodo = new Nodo(movie);
            
            if (id=="Inorden"|id=="InOrden")
            {
                nodo.InOrden(nodo(movie));                
            }
            else if (id=="Preorden"|id=="PreOrden")
            {
                nodo.PreOrden(nodo(movie));
            }
            else if (id=="Postorden"|id=="PostOrden")
            {
                nodo.PostOrden(nodo(movie));
            }

            return "Done";
        }

        // POST api/<Movies>
        [HttpPost]
        [Route("/movies/populate")]
        public void Post([FromBody] string value)
        {
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                Movies product = JsonConvert.DeserializeObject<Product>(json);
            }
        }

        // PUT api/<Movies>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Pelicula pelicula = new Pelicula();
            Nodo nodo = new Nodo(pelicula);
            nodo.delete(id);
            

        }
    }
}
