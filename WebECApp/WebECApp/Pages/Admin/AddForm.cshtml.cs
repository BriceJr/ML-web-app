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
    public class AddFormModel : PageModel
    {
        public readonly AppDataContext _db; // allowing our datacontext to be readable by everyone
        [BindProperty]
        public Product Products { get; set; } 
        public AddFormModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Products = new Product();
        }
        // sends information from our form to our data base using the add method and saves the changes using the SaveChanges method and returns the admins Page 
        public IActionResult OnPost()           
        {
            _db.Products.Add(Products);
            _db.SaveChanges();
            return RedirectToPage("Display");
        }
    }
}
