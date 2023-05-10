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
    public class ComRatModel : PageModel
    {
        public readonly AppDataContext _db;

        public ComRatModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public List<Comment> Comments { get; set; }
        public void OnGet()
        {
            Comments = _db.Comments.ToList();
        }
    }
}
