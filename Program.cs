// Slightly similar to Reacyt, we need to import the System 
using System;

// In order to use List we need to import a generic System Collection
using System.Collections.Generic;

// This is the same NameSpace across each file in this application
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting the time. From compnay file. We set the createdOn date class (year, month, day)
            DateTime created = new DateTime(2019, 2, 14);

            // Create an instance of a company. Name it whatever you like.
            Company MikoDot = new Company("Miko Dot", created);

            // Create three employees
            Employee spike = new Employee()
            {
                FirstName = "Spike",
                LastName = "Spiegel",
                Title = "Space Cowboy",
                StartDate = new DateTime(2020, 5, 29)
            };
            Employee eren = new Employee()
            {
                FirstName = "Eren",
                LastName = "Yaeger",
                Title = "Attack Titan",
                StartDate = new DateTime(2019, 12, 31)
            };
            Employee touka = new Employee()
            {
                FirstName = "Touka",
                LastName = "Kirishima",
                Title = "Barista",
                StartDate = new DateTime(2021, 2, 17)
            };

            // Assign the employees to the company
            // using List we will be assigning the company declared above to show who works there. 
            List<Employee> hiredStaff = new List<Employee>()
            {
                spike, eren, touka
            };
            MikoDot.CurrentEmployees = hiredStaff; 
            /*
                Iterate the company's employee list and generate the
                simple report shown above
                -creating a method for the class to use to display the employees. 
            */
            foreach (Employee person in MikoDot.CurrentEmployees)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} Works at {MikoDot.Name} as a(an) {person.Title} starting on {person.StartDate.ToString("d")} ");
            }

        }
    }
}