using _210626_Syntra_Emese_WebAPI_EF_Oef.Models;
using _210626_Syntra_Emese_WebAPI_EF_Oef.Controllers;
using _210626_Syntra_Emese_WebAPI_EF_Oef.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _210626_Syntra_Emese_WebAPI_EF_Oef.DB;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Services
{
    public class ProductService : IProductService
    {
        List<Models.Product> products = new List<Product>();

        public ProductService()
        {
            if (products.Count == 0)
            {
                var product1 = new Product();

                product1.productID = 0;
                product1.productName = "P1";
                product1.productPrice = 0;

                products.Add(product1);
            }
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productID)
        {
            var product = products.FirstOrDefault(x => x.productID == productID);
            return product;
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Product> GetProductsWithCategories()
        {
            using (var db = new ProductDbContext())
            {
                //var listOfProducts = db.Categories.Include(x => x.Products).ToList();
                //return listofcatgories;
                return products;
                
            }
        }

        public Product UpdateProductByID(int productIDToEdit, Product productEditValues)
        {
            throw new NotImplementedException();
        }


    }



}
