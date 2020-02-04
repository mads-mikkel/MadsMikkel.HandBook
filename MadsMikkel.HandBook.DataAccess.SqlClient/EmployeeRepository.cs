using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace MadsMikkel.HandBook.DataAccess.SqlClient
{
    public class EmployeeRepository
    {
        private const string connectionString = @"
            Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=Northwind;
            Integrated Security=True;
            Connect Timeout=30;
            Encrypt=False;
            TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False
            ";

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT (EmployeeID, FirstName, LastName, Title, " +
                "TitleOfCourtesy, BirthDate, HireDate) FROM Employees";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            return employees;
        }
    }
}
