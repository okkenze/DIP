using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {

        }

        public string GetCustomerNameDataAccess()
        {

            return "Okechukwu";
        }
    }
}
