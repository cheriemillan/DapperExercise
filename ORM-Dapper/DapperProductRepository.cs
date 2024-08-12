using System.Data;
using System.Security.Policy;
using Dapper;

namespace ORM_Dapper;

public class DapperProductRepository : IProductRepository
{
    private readonly IDbConnection _conn;

    public DapperProductRepository(IDbConnection conn)
    {
        _conn = conn;
    }
    
    public IEnumerable<Product> GetAllProducts()
    {
        return _conn.Query<Product>("SELECT * FROM products");
    }
}