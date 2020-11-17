using System;
using System.Collections.Generic;

namespace classes
{
    class Company
    {
        public Company(string nameOfCompany, DateTime dateCreated)
        {
            DateFounded = dateCreated;
            CompanyName = nameOfCompany;
        }
        public DateTime DateFounded { get; }
        public string CompanyName { get; }
        public List<Employee> Employees { get; set; }
        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {CompanyName} as {employee.Title} since {employee.StartDate}");
            }
        }
    }
}