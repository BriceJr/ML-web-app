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
    public class SalesModel : PageModel
    {
        public readonly AppDataContext _db;

        public SalesModel(AppDataContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public List<Cart> Carts { get; set; }
        public void OnGet()
        {
            Carts = _db.Sales.ToList();
        }
    }
}
