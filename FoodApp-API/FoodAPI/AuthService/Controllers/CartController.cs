using AuthService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        UserContext _context = new UserContext();

        // GET: api/<PaymentDetailController>
        [HttpGet]
        public IEnumerable<Cart> Get()
        {
            return _context.Carts.ToList();
        }

        // GET api/<PaymentDetailController>/5
        [HttpGet("{id}")]
        public Cart Get(int id)
        {
            return _context.Carts.Find(id);
        }

        // POST api/<PaymentDetailController>
        [HttpPost]
        public void Post([FromBody] Cart value)
        {
            _context.Carts.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<PaymentDetailController>/5
        [HttpPut("{id}")]
        /* public void Put(int id, [FromBody] PaymentDetail value)
         {
           //  PaymentDetail s = _context.PaymentDetails.Find(id);
             s.CardOwnerName = value.CardOwnerName;
             _context.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
             _context.SaveChanges();
         }*/

        // DELETE api/<PaymentDetailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           // PaymentDetail s = _context.c.Find(id);
           // _context.PaymentDetails.Remove(s);
           // _context.SaveChanges();
        }
    }
}
