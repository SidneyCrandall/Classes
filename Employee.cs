using System;

// another instance of Classes to be used throughout the program
namespace Classes
{
    // Public class to be used in the Main 
    public class Employee
    {
        // Some readonly properties (let's talk about gets, baby)
        // We will establish the properties of the class of Employee to later be modified
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
}