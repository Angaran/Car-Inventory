// Customer.cs
// Author:  Kyle Chapman
// Date:    March 1, 2021
// Description:
//  A class designed to as a record of an individual customer,
//  including a little information that describes their importance.

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerViewer
{
    /// <summary>
    /// A class designed to as a record of an individual customer, including a little information that describes their importance.
    /// </summary>
    class Car
    {
        // Static private variable to hold the number of customers.
        private static int carCount = 0;
        // Private variable to hold the customer's identification number.
        private int carIdentificationNumber = 0;
        // Private variable to hold the customer's title.
        private string carMake = String.Empty;
        // Private variable to hold the customer's first name.
        private string carModel = String.Empty;
        // Private variable to hold the customer's last name.
        private int carYear = 0;
        // Private variable to hold the customer's status.
        private bool carNewStatus = false;
        private decimal carPrice = 0.0M;

        /// <summary>
        /// Constructor - Default - creates a new customer object.
        /// </summary>
        public Car()
        {
            carCount += 1;
            carIdentificationNumber = carCount;
        }

        /// <summary>
        /// Constructor - Parameterized - creates a new customer object
        /// </summary>
        /// <param name="Make">Customer's title</param>
        /// <param name="Model">Customer's first name</param>
        /// <param name="lastName">Customer's last name</param>
        /// <param name="vipStatus">true if a customer is a very important person</param>
        public Car(string make, string model, int year, decimal price, bool newStatus): this()
        {
            // The ": this()" part above calls the default constructor, setting the Id.

            // Set all of the instance variables within this class using the values
            // passed into this constructor.
            carMake = make;
            carModel = model;
            carYear = year;
            carNewStatus = newStatus;
            carPrice = price;
        }

        /// <summary>
        /// Count ReadOnly Property - Gets the number of customers that have been instantiated/created
        /// </summary>
        public int Count
        {
            get
            {
                return carCount;
            }
        }

        /// <summary>
        /// IdentificationNumber ReadOnly Property - Gets a specific customers' identification number
        /// </summary>
        public int Id
        {
            get
            {
                return carIdentificationNumber;
            }
        }

        /// <summary>
        /// VeryImportantPersonStatus Property - >Gets and Sets the Very Important Person status of a customer
        /// </summary>
        public bool NewStatus
        {
            get
            {
                return carNewStatus;
            }
            set
            {
                // The value passed in is always called "value" by default.
                carNewStatus = value;
            }
        }

        /// <summary>
        /// Title property - Gets and Sets the title of a customer
        /// </summary>
        public string make
        {
            get
            {
                return carMake;
            }
            set
            {
                // The value passed in is always called "value" by default - regardless of the data type.
                carMake = value;
            }
        }

        /// <summary>
        /// FirstName property - Gets and Sets the first name of a customer
        /// </summary>
        public string model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }

        /// <summary>
        /// Year property - Gets and Sets the year of a car
        /// </summary>
        public int year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }
        public decimal price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }
        /// <summary>
        /// GetSalutation is a function that a salutation based on the private properties within the class scope
        /// </summary>
        /// <returns>string describing the customer</returns>
        public string GetCarInfo()
        {
            return "Hi, your car is " + make + " " + model + " " + year + ", " + (NewStatus ? "I am new" : "I am not new");
        }

    }
}
