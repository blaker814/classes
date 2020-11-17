using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company munderDifflin = new Company("Munder Difflin", new DateTime(2009, 11, 13));
            List<Employee> difflinEmployees = new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "Phil",
                    LastName = "Pickle",
                    Title = "Manager",
                    StartDate = new DateTime(2009, 11, 13)
                },
                new Employee()
                {
                    FirstName = "Gil",
                    LastName = "Pickle",
                    Title = "Assisstant to the Manager",
                    StartDate = new DateTime(2019, 10, 16)
                },
                new Employee()
                {
                    FirstName = "Bill",
                    LastName = "Pickle",
                    Title = "Lead Sales Rep",
                    StartDate = new DateTime(2013, 12, 29)
                }
            };
            munderDifflin.Employees = difflinEmployees;
            munderDifflin.ListEmployees();
        }
    }
}
