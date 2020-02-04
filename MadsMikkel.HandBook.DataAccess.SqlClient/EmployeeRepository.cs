using System;

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
    }
}
