using _210626_Syntra_Emese_WebAPI_EF_Oef.Services;
using _210626_Syntra_Emese_WebAPI_EF_Oef.DB;
using _210626_Syntra_Emese_WebAPI_EF_Oef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Services
{
    public class DBProductService : IProductService
    {
        private int productID;

        public void AddProduct(Product product)
        {
            using (var database = new ProductDbContext())
            {
                database.Products.Add(product);
                database.SaveChanges();
            }
        }
        public Product GetProduct(int productID)
        {
            using (var database = new ProductDbContext())
            {
                var product = database.Products.FirstOrDefault(product => product.productID == productID);
                return product;
            }
        }
        public List<Product> GetProducts()
        {
            using (var database = new ProductDbContext())
            {
                return database.Products.ToList();
            }
        }
        public void DeleteProductsById(int productId)
        {
            using (var database = new ProductDbContext())
            {

                var productToDelete = database.Products.Find(productId);
                database.Products.Remove(productToDelete);
                database.SaveChanges();
            }
        }

        public Product UpDateProductById(int productIdToEdit, Product productEditValues)
        {
            using (var database = new ProductDbContext())
            {
                var productToEdit = database.Products.First(product => product.productID == productIdToEdit);
                productToEdit.productPrice = productEditValues.productPrice;
                productToEdit.productName = productEditValues.productName;
                database.Products.Update(productToEdit);
                database.SaveChanges();
                return productToEdit;

            }
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProductByID(int productIDToEdit, Product productEditValues)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsWithCategories()
        {

            throw new NotImplementedException();
        }
        
    }
}
