using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void DeleteProduct(int id)
        {
            _conn.Execute("delete from sales where ProductID = @id", new { id = id });
            _conn.Execute("delete from reviews where ProductID = @id", new { id = id });
            _conn.Execute("delete from products where ProductID = @id", new { id = id });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("select * from products;");
        }

        public Product GetProductById(int id)
        {
            return _conn.QuerySingle<Product>("select * from products where ProductID = @id;", new {id = id});
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("update products set Name =@name, Price = @price, OnSale = @onSale, StockLevel = @stock where ProductID = @id", 
                new { id = product.ProductID, name = product.Name, price = product.Price, onSale= product.onSale, stock = product.stockLevel});
        }
    }
}
