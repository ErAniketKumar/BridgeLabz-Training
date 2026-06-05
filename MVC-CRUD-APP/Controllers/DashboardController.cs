using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_APP.Data;
using MVC_CRUD_APP.Dto;
using Microsoft.EntityFrameworkCore;
using MVC_CRUD_APP.Models;
using System.Drawing;
using Microsoft.AspNetCore.Authorization;

namespace MVC_CRUD_APP.Controllers
{
    [Authorize]
    public class DashboardController(AppDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var list = await _context.Products.Select(x => new ProductDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    Color = x.Color
                })
                .ToListAsync();

            return View(list);
        }

        public IActionResult AddProductForm()
        {
            return View();
        }
        public async Task<IActionResult> AddProduct(ProductDto dto) {
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                Color = dto.Color
            };

            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Product added successfully!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> EditProductForm(int id)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
                return NotFound();

            var dto = new EditProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Color = product.Color
            };

            return View(dto);
        }
        public async Task<IActionResult> EditProduct(int id,EditProductDto dto) 
        {
            var existingProduct = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);

            existingProduct?.Name = dto.Name;
            existingProduct?.Description = dto.Description;
            existingProduct?.Price = dto.Price;
            existingProduct?.Color = dto.Color;
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Product Updated!";

            return RedirectToAction(nameof(Index));

        }
     
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
                return NotFound();

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Product Deleted Successfully!";

            return RedirectToAction(nameof(Index));
        }
    }
}
