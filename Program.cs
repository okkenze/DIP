using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerBL custBL = new CustomerBL();
            var customerName = custBL.GetCustomerNameBL();

            Console.WriteLine("Customer Name is: " + customerName);

            Console.ReadLine();
        }
    }
}
