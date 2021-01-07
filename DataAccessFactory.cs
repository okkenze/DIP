﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerName()
        {
            return new CustomerDataAccess();
        
        }
    }
}
