using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebECApp.Models;

namespace WebECApp.Pages
{
    // creating an exclusive section for registered user to view specified range of products
    [Authorize]
    public class ExclusivesModel : PageModel
    {
        public readonly AppDataContext _db;

        public ExclusivesModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _db.Products.OrderByDescending(x => x.Id).Take(3).ToList();
        }
    }
}
