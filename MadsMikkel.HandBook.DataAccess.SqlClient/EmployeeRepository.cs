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
            string sql = "SELECT EmployeeID, FirstName, LastName, Title, " +                       
                "TitleOfCourtesy, BirthDate, HireDate FROM Employees";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int id = reader.GetFieldValue<int>(0);
                string firstname = reader.GetFieldValue<string>(1);
                string lastname = reader.GetFieldValue<string>(2);
                string title = reader.GetFieldValue<string>(3);
                string titleOfCourtesy = reader.GetFieldValue<string>(4);
                DateTime birthDate = reader.GetFieldValue<DateTime>(5);
                DateTime hireDate = reader.GetFieldValue<DateTime>(6);

                Employee employee = new Employee
                {
                    Id = id,
                    Firstname = firstname,
                    Lastname = lastname,
                    Title = title,
                    TitleOfCourtesy = titleOfCourtesy,
                    BirthDate = birthDate,
                    HireDate = hireDate
                };

                employees.Add(employee);
            }

            connection.Close();
            return employees;
        }

        public void Add(Employee employee) 
        {
            string sql = $"INSERT INTO Employees " +
                $"(FirstName, LastName, Title, TitleOfCourtesy, BirthDate, HireDate) " +
                $"VALUES ('{employee.Firstname}', '{employee.Lastname}', " +
                $"'{employee.Title}', '{employee.TitleOfCourtesy}', " +
                $"'{employee.BirthDate.ToString("s")}'," +
                $"'{employee.HireDate.ToString("s")}')";
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
