// Slightly similar to React, we need to import the System 
using System;

// In order to use List (not recognized in C#) we need to import a generic System Collection
using System.Collections.Generic;

// This allows classes to be used throughout the code. 
namespace Classes
{
    // This allows Company to be used through out the main program
    // Also giving properties to the class company
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        // get allows program to see the thing.
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        // Set is used to modify the thing
        // 'News Flash: Declaring a property gives it an initial value of null' - Chapter 12, Bangazon
        public List<Employee> CurrentEmployees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        // Constructor creat new objects for a class
        public Company(string nameOfCompany, DateTime createdOn)
        {
            Name = nameOfCompany;
            CreatedOn = createdOn;
        }
    }
}