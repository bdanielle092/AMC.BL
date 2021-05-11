﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {

        //this establishes a collaborative relationship between the CustomerRepository and the AddressRepository
        public CustomerRepository()
            {

            //creating an instance of the address repository in the constructor
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
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
                //calling the RetrieveByCustomerId method and populate the address list. Call the ToList to return the result as a list
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
