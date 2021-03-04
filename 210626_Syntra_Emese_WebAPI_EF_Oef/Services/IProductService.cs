using _210626_Syntra_Emese_WebAPI_EF_Oef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Services
{
    public interface IProductService
    {

        Product GetProduct(int productID);
        List<Product> GetProducts();
        void AddProduct(Models.Product product);
        void DeleteProduct(int productId);
        Product UpdateProductByID(int productIDToEdit, Product productEditValues);
        List<Product> GetProductsWithCategories();
    }
}
