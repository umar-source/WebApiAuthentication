using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiAuthentication.Models;

namespace WebApiAuthentication.DAL
{
    public class AuthDbContext : IdentityDbContext
    {

        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        { 

        }

        
       public DbSet<Employee> Employee { get; set; }


    }
}
