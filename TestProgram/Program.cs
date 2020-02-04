using System;
using MadsMikkel.HandBook.DataAccess.SqlClient;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();

            foreach(var item in repository.GetAll())
            {
                Console.WriteLine(item.Firstname);
            }
        }
    }
}
