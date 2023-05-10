using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebECApp.Models;

namespace WebECApp.Pages
{
    public class ProductsModel : PageModel
    {
        public readonly AppDataContext _db;

        public ProductsModel(AppDataContext db)
        {
            _db = db;
        }
        // Enables the information found in our db on the products table to be displayed as list
        [BindProperty(SupportsGet = true)]
        public IList<Product> Products { get; set; } 
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public SelectList Brand { get; set; }    // specifying we want to get at different brands as a list
        [BindProperty(SupportsGet = true)]
        [ViewData]
        public string ProdBrand { get; set; }
        public SelectList Category { get; set; }
        [BindProperty(SupportsGet = true)]
        [ViewData]
        public string ProdCategory { get; set; }
        [BindProperty(SupportsGet = true)]
        public string StringSearch { get; set; }
        // renders a list of the properties in our table when a get request is made by the page
        public async Task OnGetAsync()
        {
            IQueryable<string> brandQuery = from m in _db.Products           //getting the list of brands
                                            orderby m.Brand
                                            select m.Brand;
            IQueryable<string> catQuery = from m in _db.Products           //getting the list of Categories
                                          orderby m.Category
                                          select m.Category;
            var products = from m in _db.Products
                           select m;
            if (!string.IsNullOrEmpty(StringSearch))
            {
                products = products.Where(s => s.Name.Contains(StringSearch));
            }
            if (!string.IsNullOrEmpty(ProdBrand))
            {
                products = products.Where(x => x.Brand == ProdBrand);
            }
            if (!string.IsNullOrEmpty(ProdCategory))
            {
                products = products.Where(x => x.Category == ProdCategory);
            }
            Category = new SelectList(await catQuery.Distinct().ToListAsync());
            Brand = new SelectList(await brandQuery.Distinct().ToListAsync());
            Products = await products.ToListAsync();

        }
    }
}
