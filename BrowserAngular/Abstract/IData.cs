using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrowserAngular.Abstract
{
    public interface IData
    {
        void save();
        Customer GetCustomer(int id);
        Order GetOrder(int id);
        List<Customer> GetCustomers();
        List<Order> GetOrders();
        void delete();
    }
}