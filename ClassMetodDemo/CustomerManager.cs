using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo;
using ClassMetodDemo;
class CustomerManager
{   public void Add (Customer customer)
    {
        Console.WriteLine(customer.Name + " " + customer.SurName + ":" + customer.TCKno + "Well Done.Costumer Added!");
    }
    public void List(Customer customer) 
    {
        Console.WriteLine(customer.Name+ " " + customer.SurName + "=" + customer.TCKno + customer.CustomerNo + "Thx Dude.Costumer Listed!");
    }
    public void Delete(Customer customer)
    {
        Console.WriteLine(customer.Name + " " + customer.SurName + ":" + " " + customer.CustomerClass + "Byss.Costumer Deleted!");
    }

 
}