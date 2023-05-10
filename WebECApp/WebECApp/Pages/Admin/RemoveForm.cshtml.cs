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
    public class RemoveFormModel : PageModel
    {
        public readonly AppDataContext _db;
        public Product Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public RemoveFormModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Products = _db.Products.Find(Id);
        }
        // Access product in our specified Db by finding the Id and then deletes and saves using Remove and SaveChanges methods respectively
        public IActionResult OnPost()    
        {
            _db.Remove(_db.Products.Find(Id));
            return RedirectToPage("Display");
        }
    }
}
