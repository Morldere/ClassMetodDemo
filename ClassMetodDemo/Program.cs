using System;
using System.Xml.Linq;


namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer
            {
                Id = 12345,
                Name = "Orkun",
                SurName = "Polat",
                TCKno = 2832222222225,
                CustomerNo = 23234,
                CustomerClass = "S+",
            };

            Customer customer2 = new Customer
            {
                Id = 23456,
                Name = "Sevban",
                SurName = "Ateş",
                TCKno = 28392575222225,
                CustomerNo = 31693,
                CustomerClass = "S+",

            };
            Customer customer3 = new Customer
            {
                Id = 34567,
                Name = "Oto",
                SurName = "Teyip",
                TCKno = 11111222222111,
                CustomerNo = 51545,
                CustomerClass = "D-",

            };
            Customer customer4 = new Customer
            {
                Id = 45678,
                Name = "Selman",
                SurName = "Aldemir",
                TCKno = 2132131231232,
                CustomerNo = 65347,
                CustomerClass = "S-"
            };
            Customer[] customers = new Customer[]
            {
                customer1, customer2, customer3, customer4  
            };
            foreach (Customer customer in customers) 
            {
                Console.WriteLine(customer.Name + " " + customer.SurName + ":" + customer.CustomerNo + " = " + customer.CustomerClass );
            }
            
            Console.WriteLine("-----------------");

            Console.ReadLine();



        }   
            



    }
}


