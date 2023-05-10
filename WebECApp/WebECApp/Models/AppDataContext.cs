using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebECApp.Models
{
    // Data inheriting from Db context class....we will update to inherit from identity dbcontext
    public class AppDataContext : IdentityDbContext<AppUser>
    {
        // enabling our database context to make use of options which are specified is startup.cs
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) { } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Sales { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Return> Returns { get; set; }
    }
}
