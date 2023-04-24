using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppIdentity1.Models;


namespace WebAppIdentity1.Data
{



    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        public DbSet<MyRegisteredUser> MyRegisteredUsers { get; set; }
    }
}