using ApiCrud.Models;
using ApiCrud.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _productService.GetProductsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            var product = await _productService.GetProductAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchProduct(Guid id, [FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Dados inválidos");
            }

            var existingProduct = await _productService.GetProductAsync(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            if (product.Name != null)
            {
                existingProduct.Name = product.Name;
            }
            if (product.Description != null)
            {
                existingProduct.Description = product.Description;
            }
            if (product.Price != default)
            {
                existingProduct.Price = product.Price;
            }

            await _productService.UpdateProductAsync(existingProduct);

            return Ok(existingProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            if (!_productService.ProductExists(id))
            {
                return NotFound();
            }

            await _productService.DeleteProductAsync(id);
            return NoContent();
        }
    }
}
