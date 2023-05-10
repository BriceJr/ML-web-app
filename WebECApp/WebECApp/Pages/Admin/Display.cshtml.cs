using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebECApp.Models;

namespace WebECApp.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class DisplayModel : PageModel
    {
        public readonly AppDataContext _db;

        public DisplayModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _db.Products.ToList();
        }
    }
}
