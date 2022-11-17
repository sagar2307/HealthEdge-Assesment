using HealthEdge.Model;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthEdge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        List<Inventory> Products = new List<Inventory>()
        {
            new Inventory("Apple", 3, DateTime.Today),
            new Inventory("Oranges", 7, DateTime.Today),
            new Inventory("Pomegranates",55, DateTime.Today)
        };
            
        

        // GET: api/<ValuesController1>
        // Show all products that are in the List
        [HttpGet]
        public List<Inventory> Get()
        {
            return Products;
        }

        // GET api/<ValuesController1>/[name of the item]
        // Show the item that has the matching name. Search by name of the product
        [HttpGet("{name}", Name = "Get")]
        public Inventory Get(string name)
        {
            Inventory item = Products.Find(f => f.name == name);
            return item;
        }

        // POST api/<ValuesController1>/[name and details of new item in the body]
        [HttpPost]
        public List<Inventory> Post([FromBody] Inventory item)
        {
            Products.Add(item);
            return Products;
        }

        // PUT api/<ValuesController1>/[name of the item]
        [HttpPut("{name}")]
        public List<Inventory> Put(string name, [FromBody] Inventory item)
        {
            Inventory updateItem = Products.Find(f => f.name == name);
            int n = Products.IndexOf(updateItem);
            Products[n].name = item.name;
            Products[n].quantity = item.quantity;
            Products[n].date = item.date;

            return Products;
        }

        // DELETE api/<ValuesController1>/[name of the item]
        [HttpDelete("{name}")]
        public List<Inventory> Delete(string name)
        {
            Inventory item = Products.Find(f=> f.name == name);
            Products.Remove(item);
            return Products;
        }
    }
}
