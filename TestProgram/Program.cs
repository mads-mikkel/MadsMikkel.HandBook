using System;
using MadsMikkel.HandBook.DataAccess.SqlClient;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.GetAll();
        }
    }
}
