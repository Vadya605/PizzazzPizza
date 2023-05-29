using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace server
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly IngredientService _ingredientService;
        private readonly FeatureService _featureService;
        public ProductController(EF_DataContext dataContext){
            _productService = new ProductService(dataContext);
            _ingredientService = new IngredientService(dataContext);
            _featureService = new FeatureService(dataContext);
        }

        [HttpGet]
        [Route("api/[controller]/all_products")]
        public IActionResult GetAll(){
            List<Product>? allProducts = _productService.GetAllProducts();
            if(!allProducts.Any()){
                return NotFound();
            }
            allProducts.ForEach(product =>
                product.productIngredients = _ingredientService.GetProductIngredients(product.id)
            );
            return Ok(
                allProducts
            );
        }

        [HttpGet]
        [Route("api/[controller]/type/{productType}")]
        public IActionResult GetByType(string productType){
            List<Product>? specificTypeProducts = _productService.GetProductsByType(productType);
            if(!specificTypeProducts.Any()){
                return NotFound();
            }
            specificTypeProducts.ForEach(product =>
                product.productIngredients = _ingredientService.GetProductIngredients(product.id)
            );
            return Ok(
                specificTypeProducts
            );
        }

        [HttpGet]
        [Route("api/[controller]/{productId}")]
        public IActionResult GetById(int productId){
            Product? specificIdProduct = _productService.GetProductById(productId);
            if(specificIdProduct == null){
                return NotFound();
            }
            specificIdProduct.productIngredients = _ingredientService.GetProductIngredients(productId);
            specificIdProduct.productFeatures = _featureService.GetProductFeatures(productId);
            return Ok(
                specificIdProduct
            );
        }
    }
}
