using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebECApp.Models;

namespace WebECApp.Pages
{
    public class IndexModel : PageModel
    {
        public readonly AppDataContext _db;
        public List<Product> Products { get; set; } = new List<Product>();
        public IList<Comment> Comments { get; set; }
        public IndexModel(AppDataContext db)
        {
            _db = db;
        }
        // getting as a specified range of products and comments for our index page
        public void OnGet()
        {
            Comments = _db.Comments.OrderByDescending(x => x.CommentID).Take(3).ToList();
            Products = _db.Products.OrderByDescending(x => x.Id).Take(12).ToList();
        }
    }
}
