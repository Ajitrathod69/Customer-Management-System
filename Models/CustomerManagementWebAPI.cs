using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer_Management_System.Models
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]

    public class CustomerManagementWebAPI : ControllerBase
    {
        // GET: api/<CustomerManagementWebAPI>
        [HttpGet]
       
        public string GetRecords()
        {
            DBHandle db = new DBHandle();
            return db.GetAllRecords();
        }

        [Route("fetch")]
        public Customer getCustomer(int Customer_ID)
        {
            DBHandle db = new DBHandle();
            return db.getCustomerDetail(Customer_ID);
             
        }

       

        // POST api/<CustomerManagementWebAPI>
        [HttpPost]
        [Route("Register")]
        public void Post(Customer c)
        {
            DBHandle db = new DBHandle();
            db.AddCustomer(c);
            return;
        }

        // PUT api/<CustomerManagementWebAPI>/5
        [HttpPut]
        public void CustomerDetail(Customer c)
        {
            DBHandle db = new DBHandle();
            db.UpdateCustomer(c);
            return;
        }

        // DELETE api/<CustomerManagementWebAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DBHandle db = new DBHandle();
            db.DeleteCustomer(id);
            return;
        }
    }
}
