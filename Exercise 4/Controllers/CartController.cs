using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private static Dictionary<int, List<Product>> carts = new Dictionary<int, List<Product>>();

        [HttpGet("{userId}")]
        public ActionResult<IEnumerable<Product>> Get(int userId)
        {
            if (!carts.ContainsKey(userId))
                    return StatusCode(404);
            
            return Ok(carts[userId]);
        }
        
        [HttpPost("{userId}")]
        public ActionResult<IEnumerable<Product>> Post(int userId, [FromBody] Product product)
        {
            if (!carts.ContainsKey(userId))
                carts.Add(userId, new List<Product>());
            
            carts[userId].Add(product);
            
            return Ok(carts[userId]);
        }
        [HttpDelete("{userId}")]
        public ActionResult Delete(int userId)
        {
            if (!carts.ContainsKey(userId))
                carts.Add(userId, new List<Product>());
            
            carts[userId].Add(product);
            
            return Ok(carts[userId]);
        }
        
        
        
        
    }
}