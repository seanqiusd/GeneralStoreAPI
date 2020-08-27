using GeneralStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeneralStoreAPI.Controllers
{
    public class CustomerController : ApiController
    {
        private StoreDbContext _context = new StoreDbContext();

        // Post --Create
        public IHttpActionResult Post(Customer customer)
        {

            // if an empty Customer is passed in (returned) // validations we are passing in; we do validations 
            if (customer == null)
            {
                return BadRequest("Your request body cannot be empty.");
            }

            // if the ModelState is not Valid // validations we are passing in 
            if (ModelState.IsValid) // .IsValid is just another way of saying == true; ModelState is inherited from ApiController
            {
                _context.Customers.Add(customer); // Adding customer to dbset // and to make this persist, we have to save next
                _context.SaveChanges(); // save changes
                return Ok(); // return an ok
            }
            return BadRequest(ModelState); // if none of the previous two ifs hit, then return BadRequest
        }
        
        // Get --Read All
        public IHttpActionResult Get()
        {
            List<Customer> customers = _context.Customers.ToList();
            if (customers.Count != 0)
            {
                return Ok(customers);

            }
            return BadRequest("Your database contains no Customers");
        }

        // Get{id} --Read By ID
        public IHttpActionResult Get(int id)
        {
            
            Customer customer = _context.Customers.Find(id);
            // if id is 0
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // Put {id} --Update

        // Delete {id} --Delete By ID


    }
}
