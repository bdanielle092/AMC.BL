﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {
public Customer Retrieve(int customerId)
        {
            //create the instance of the Customer class
            //Pass in the requested id
            Customer customer = new Customer(customerId);

            //Code that retreves the defined customer

            //Temporary hard-coded values to return a popluated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        //Saves the current customer
        public bool Save( Customer customer)
        {
            //code that saves the passed in customer
            return true;
        }
    }
}
