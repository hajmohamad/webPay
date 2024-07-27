using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webPay.Models;

namespace webPay.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly WebPayDbContext _dbContext = new();
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _dbContext.Customers.Include(c => c.MemberShipType).ToList();
            
        }

        [HttpGet("{id}")]

        public Customer? GetCustomer(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            if (customer == null)
            {
                
            }
        
            return customer;
            
        }

        [HttpDelete("{id}")]
        public IActionResult  Delete(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();

            }
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
            return Ok();

            
        }

        [HttpPost]
        public IActionResult  CreateCustomer(Customer customer)
        {
    
       
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
             return  CreatedAtAction("GetCustomer", new {id = customer.Id}, customer);
        }

         [HttpPut]
        public void UpdateCustomer(int id ,Customer customer)
        {

            var customerInDb = _dbContext.Customers.Find(id);
            if (customerInDb == null)
            {
                return;
            }
            customerInDb.Name = customer.Name;
            customerInDb.DateOfBirth = customer.DateOfBirth;
            customerInDb.IsSubscribed = customer.IsSubscribed;
            customerInDb.MemberShipTypeId = customer.MemberShipTypeId;
            _dbContext.SaveChanges();
        }
    }
}
