﻿using Eticaret.Data;
using Eticaret.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string q = "")
        {
            var databaseContext = _context.Products.Where(p => p.IsActive && p.Name.Contains(q) || p.Description.Contains(q) ).Include(p => p.Brand).Include(p => p.Category);
            return View(await databaseContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(p => p.Brand).Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var model = new ProductDetailViwModel{ Product = product, 
            RelatedProducts = _context.Products
            .Where(p => p.IsActive && p.CategoryId == product.CategoryId && p.Id != product.Id).ToList()
            };

            return View(model);
        }
    }
}
