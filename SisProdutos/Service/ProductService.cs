using System;
using SisProdutos.models;
using SisProdutos.Config;
using System.Linq;
using System.Collections.Generic;

namespace SisProdutos.Service
{
    public class ProductService
    {

        DbContextProduct context = new DbContextProduct();
        public Product AddProduct(Product product)
        {
            product.DateCreate = DateTime.Now;
            
            context.Products.Add(product);
   
            context.SaveChanges();

            return product;
        }

        public List<Product> ListProducts()
        {
            var result = context.Products.ToList();

            return result;
        }


    }
}
