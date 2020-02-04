using System;
using MadsMikkel.HandBook.DataAccess.SqlClient;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();

            Employee newEmployee = new Employee
            {
                Firstname = "Mads",
                Lastname = "Rasmussen",
                Title = "Programmer",
                TitleOfCourtesy = "Mr.",
                BirthDate = new DateTime(1983, 05, 19),
                HireDate = new DateTime(2013, 12, 01)
            };

            repository.Add(newEmployee);

            foreach(var item in repository.GetAll())
            {
                Console.WriteLine( item.BirthDate.ToString("yyyy-MM-dd"));
            }
        }
    }
}
