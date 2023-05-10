using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebECApp.Models;

namespace WebECApp.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly AppDataContext _db;
        // cart property of type list inheriting from cart class
        public List<Cart> Cart { get; set; }
        public decimal Total { get; set; }

        public CheckoutModel(AppDataContext db)
        {
            _db = db;
        }
        //obtaining list of items stored in session displaying in cart and calculating total
        public void OnGet()             
        {
            Carts = new Cart();
            Cart = SessionHelp.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            Total = 10 + Cart.Sum(Cart => Cart.Product.Price * Cart.Quantity);
        }
        // storing items from the product page in session throug id parameter
        public IActionResult OnGetBuy(string id)               //(inspired from https://learningprogramming.net/net/asp-net-core-mvc/ )
        {
            var Product = _db.Products.Find(id);
            var cart = SessionHelp.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            // defining condition product added to empty cart
            if (cart == null)
            {
                cart = new List<Cart>();
                cart.Add(new Cart()
                {
                    Product = Product,
                    Quantity = 1
                });
                // storing in session
                SessionHelp.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            // defining condition for an item already being present in cart
            else
            {
                var index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new Cart()
                    {
                        Product = Product,
                        Quantity = 1
                    });
                }
                // definig condition for an item added twice(increments quantity property)
                else
                {
                    var newQuantity = cart[index].Quantity + 1;
                    cart[index].Quantity = newQuantity;
                }
                SessionHelp.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            // showing checkout everytime an item is added
            return RedirectToPage("Checkout");
        }
        // removing an item from cart through id parameter
        public IActionResult OnGetDelete(string id)
        {
            var cart = SessionHelp.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            var index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelp.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("Checkout");
        }
        // defining the conditions for adding same item to cart twice
        private int Exists(List<Cart> cart, string id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        // storing our purchases to our sales database
        [BindProperty]
        public Cart Carts { get; set; }
        public IActionResult OnPost()
        {
            _db.Sales.Add(Carts);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
