using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebECApp.Models;

namespace WebECApp.Pages
{
    public class DetailsModel : PageModel
    {
        public readonly AppDataContext _db;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public Product Products { get; set; }
        // defining comments property and binding for passing data
        [BindProperty(SupportsGet = true)]
        public Comment Comments { get; set; }
        public DetailsModel(AppDataContext db)
        {
            _db = db;
        }
        // getting at routed product through id
        public void OnGet()
        {
            Comments = new Comment();
            Products = _db.Products.Find(Id);
        }
        // uploading comments to comments table
        public IActionResult OnPost()
        {
            _db.Comments.Add(Comments);
            _db.SaveChanges();
            return RedirectToPage("Products");
        }
    }
}
