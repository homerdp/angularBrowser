using BrowserAngular.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BrowserAngular;

namespace BrowserAngular.Concrete
{
    public class DbEntity : IData
    {
        TetsContainer db = new TetsContainer(); 
 
        public void save()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            
            Customer customer = (from b in db.CustomerSet where b.CustomerId == id select b).SingleOrDefault(); 
            return customer;
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }
    }
}