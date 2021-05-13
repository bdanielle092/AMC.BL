using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //public mean this class is callable from another part of the app
    //each class we define is a type
    public class Customer : EntityBase
    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }

        //auto-implemented property. Behide the sense the code is still creating a backing field
        public string FirstName { get; set; }
        //the code should be encapsulated that mean the actually data is hidden within the class
        //and access to that data is provide with accessors 
        //private hides the data

        public string FullName
        {
            get
            {
                // there is a lastName displayed the fullname is the last name with no commas
                //if there is a fullname we start with the last name 
                string fullName = LastName;
                //if there is only a firstName the full name is initially null
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    //so we set the full name to the firstName
                    //add a comma
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    //before appending the firstName
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        private string _lastName;

        //properties are usually define with a public access modifier meaning any code can use it to get or set the data
        //interal means the access is limited to code interal to the project in which it is defined
        //if there is no need for logic use a auto-implemented property otherwise use the full property snytax 
        public string LastName
        {
            //get the property value
            //leave off the getter to create a writeOnly property
            get
            {
                return _lastName;
            }
            //set the property value
            //leave off the setter to create a readOnly property
            set
            {
                _lastName = value;
            }
        }
        public static int InstanceCount { get; set; }

        public override string ToString() => FullName;

        //Validates the customer data
        //method is public so another code in the app can call it 
        //bool - true or false value
        public override bool Validate()
        {
            //vaildate the properties of the value
            var isVaild = true;
            //check that the lastName and EmailAddress are not empty or white space
            if (string.IsNullOrWhiteSpace(LastName)) isVaild = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isVaild = false;
            return isVaild;
        }

    }
}


