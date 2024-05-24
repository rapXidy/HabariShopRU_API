using Dapper;
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
	            [Id] [uniqueidentifier] PRIMARY KEY IDENTITY NOT NULL,
	            [Name] [nvarchar](max) NULL,
	            [Location] [nvarchar](max) NULL,
	            [CustomerType] [nvarchar](50) NULL,
	            [DateCreated] [datetime] NULL,
            );";

            await dbConnection.ExecuteAsync(createTableQuery);

            await _next(context);
        }
    }
}
