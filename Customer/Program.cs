using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Customer
{
    public class customer
    {
        public int custid { get; set; }
        public string name { get; set; }

        public string city { get; set; }

        public double balance { get; set; }
    }
    class TestCustomer
    {
        static void Main(string[] args)
        {
            List<customer> customers = new List<customer>();
            customer c = new customer { custid = 101, name = "akshata", city = "akola",balance=5000 };
            customer c1 = new customer { custid = 102, name = "ak", city = "akola", balance = 5000 };
            customer c2 = new customer { custid = 103, name = "aksh", city = "akola", balance = 5000 };
            customer c3 = new customer { custid = 104, name = "akhata", city = "akola", balance = 5000 };

            customers.Add(c);
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            foreach(customer obj in customers)
            {
                Console.WriteLine(obj.custid + " " + obj.name+" "+obj.city+" "+obj.balance);
            }



        }
    }

}