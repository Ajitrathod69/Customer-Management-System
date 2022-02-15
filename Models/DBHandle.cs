using Newtonsoft.Json;

namespace Customer_Management_System.Models
{
    public class DBHandle
    {
        public string GetAllRecords()
        {
            EFDBhandle db = new EFDBhandle();
            var ListC = from c in db.Customers
                        select new
                        {
                            Customer_ID = c.Customer_ID,
                            FirstName = c.FirstName,
                            LastName = c.LastName,
                            Country = c.Country,
                            Created_Date = c.Created_Date
                        };
            List<Customer> ListP= new List<Customer>(); 
            foreach(var Lista in ListC)
            {
                Customer e = new Customer();
                e.Customer_ID = Lista.Customer_ID;
                e.FirstName = Lista.FirstName;
                e.LastName = Lista.LastName;
                e.Country = Lista.Country;
                e.Created_Date = Lista.Created_Date;
                ListP.Add(e);
            }
            return JsonConvert.SerializeObject(ListP);

        }
        public void AddCustomer(Customer c)
        {
           
            EFDBhandle db = new EFDBhandle();
            c.Created_Date = DateTime.Now;
            db.Customers.Add(c);
            db.SaveChanges();
            return;
        }
        
       public void DeleteCustomer(int Customer_ID)
        {
            EFDBhandle db = new EFDBhandle();
            Customer c = db.Customers.Find(Customer_ID);
            db.Customers.Remove(c);
            db.SaveChanges();
            return;

        }
        public Customer getCustomerDetail(int Customer_ID)
        {
            EFDBhandle db = new EFDBhandle();
            Customer c = db.Customers.Find(Customer_ID);
            return c;
        }
        public void UpdateCustomer(Customer c)
        {
            EFDBhandle db = new EFDBhandle();
            Customer e = db.Customers.Find(c.Customer_ID);
            e.FirstName = c.FirstName;
            e.LastName = c.LastName;
            e.Country = c.Country;
            db.SaveChanges();
        }
    }
}
