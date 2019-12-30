using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace ProductLibrary
{
    public class ProductsProvider
    {
        private const string CONN_STRING = "Server=db;Database=product-db;User Id=sa;Password=CorrectHorseBatteryStapleFor$;";
        private const string QUERY = "SELECT Id, Name, Description FROM product";
        
        public Product[] GetAll()
        {
            using (var connection = new SqlConnection(CONN_STRING))
            {
                return connection.Query<Product>(QUERY).ToArray();
            }
        }
    }
}
