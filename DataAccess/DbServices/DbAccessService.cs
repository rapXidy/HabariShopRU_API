using HabariShopRU.API.DataAccess.IDbServices;
using System.Data;
using System.Data.SqlClient;

namespace HabariShopRU.API.DataAccess.DbServices
{
    public class DbAccessService: IDbAccessService
    {
        private readonly IConfiguration _configuration;

        public DbAccessService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection conn
        {
            get
            {
                 return new SqlConnection(_configuration["ConnectionStrings:DevConnection"]);
            }
        }
    }
}
