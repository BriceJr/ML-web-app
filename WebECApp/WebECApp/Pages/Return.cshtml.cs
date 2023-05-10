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
    [Authorize]
    public class ReturnModel : PageModel
    {
        public readonly AppDataContext _db; // allowing our datacontext to be readable by everyone
        [BindProperty]
        public Return Returns { get; set; } 
        public ReturnModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Returns = new Return();
        }
        // sends information from our form to our data base using the add method and saves the changes using the SaveChanges method and returns the admins Page 
        public IActionResult OnPost()
        {
            _db.Returns.Add(Returns);
            _db.SaveChanges();
            return RedirectToPage("About");
        }
    }
}
