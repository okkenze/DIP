using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class CustomerBL
    {
        public CustomerBL()
        {

        }

        public string GetCustomerNameBL()
        {

            
            ICustomerDataAccess obj = DataAccessFactory.GetCustomerName();
            var name = obj.GetCustomerNameDataAccess();
            return name;
        }
    }
}
