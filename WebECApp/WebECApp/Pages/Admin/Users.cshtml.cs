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
    public class UsersModel : PageModel
    {
        public readonly AppDataContext _db;

        public UsersModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public List<AppUser> Users { get; set; }
        public void OnGet()
        {
            Users = _db.Users.ToList();
        }
    }
}
