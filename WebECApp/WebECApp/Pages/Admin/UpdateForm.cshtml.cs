using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebECApp.Models;

namespace WebECApp.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class UpdateFormModel : PageModel
    {
        public readonly AppDataContext _db;
        [BindProperty]
        public Product Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public UpdateFormModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Products = _db.Products.Find(Id);
        }
        // Access product in our specified Db by finding the Id and then updates and saves using EntityState.Modified and SaveChanges methods respectively
        public IActionResult OnPost()                             
        {
            // note that EntityState.Modified is used here to keep track of changes made to our database
            _db.Entry(Products).State = EntityState.Modified;    
            _db.SaveChanges();
            return RedirectToPage("Display");
        }
    }
}
