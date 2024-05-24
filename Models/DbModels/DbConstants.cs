namespace HabariShopRU.API.Models.DbModels
{
    public class DbConstants
    {
        public const string GetSingleCustomer = @"
                    SELECT TOP (1) * FROM Customers
                    WHERE Id = @Id;
                ";
    }
}
