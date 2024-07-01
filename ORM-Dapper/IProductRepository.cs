﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProductById(int id);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}
