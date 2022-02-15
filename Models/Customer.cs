using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer_Management_System.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime Created_Date { get; set; }
        
    }
    public class EditCustomer
    {
        [Display(Name ="Customer")]
        public int Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street_Address { get; set; }
        public string Phone { get; set; }
    }
}
