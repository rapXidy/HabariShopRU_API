using System.Data;

namespace HabariShopRU.API.BusinessLogic.Extensions
{
    public class SeedData
    {
        private readonly RequestDelegate _next;

        public SeedData(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IDbConnection dbConnection)
        {
            dbConnection.Open();

            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Customers' and xtype='U')
            CREATE TABLE Customers (
                Id INT PRIMARY KEY IDENTITY,
                Name NVARCHAR(100) NOT NULL,
                Email NVARCHAR(100) NOT NULL
            );";

            dbConnection.Execute(createTableQuery);

            await _next(context);
        }
    }
}
