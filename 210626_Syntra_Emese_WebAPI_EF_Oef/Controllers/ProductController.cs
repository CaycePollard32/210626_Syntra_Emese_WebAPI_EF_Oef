using _210626_Syntra_Emese_WebAPI_EF_Oef.Models;
using _210626_Syntra_Emese_WebAPI_EF_Oef.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _210626_Syntra_Emese_WebAPI_EF_Oef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Services.IProductService _productService;
        public ProductController(Services.IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet("many")]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
        [HttpGet("one")]
        public ActionResult<Product> GetProduct(int productID)
        {
            var product = _productService.GetProduct(productID);
            if (product == null)
            {
                return NotFound();

            }
            return Ok(product);
        }
        [HttpGet("many incl. categories")]
        public ActionResult<List<ResponseProductsWithCategories>> GetProductsWithCategories()
        {
            var products = _productService.GetProducts();
            var listOfProducts = new List<ResponseProductsWithCategories>();

            foreach (var product in products)
            {
                var responseProduct = new ResponseProductsWithCategories();
                responseProduct.productId = product.productID;
                responseProduct.productName = product.productName;
                responseProduct.productPrice = product.productPrice;


                foreach (Category cat in product.Categories)
                {
                    var responseCategory = new ResponseCategoryDTO();
                    responseCategory.Id = cat.ID;
                    responseCategory.Name = cat.categorieName;
                    responseProduct.categories.Add(responseCategory);

                }
                listOfProducts.Add(responseProduct);
            }

            return Ok(listOfProducts);
        }
        [HttpPost]
        public ActionResult AddNewProduct(Models.Product newProduct)
        {
            _productService.AddProduct(newProduct);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteProductbyID(int productID)
        {
            _productService.DeleteProduct(productID);
            return Ok();
        }
        [HttpPut]
        public ActionResult<Models.Product> UpdateProductById(int productIDToEdit, Models.Product productEditValues)
        {
            var updatedProduct = _productService.UpdateProductByID(productIDToEdit, productEditValues);
            return Ok(updatedProduct);


        }
    }
}
