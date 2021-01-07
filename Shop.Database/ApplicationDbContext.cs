using Microsoft.AspNetCore.Identity.EntityFrameWorkCore;
using System;

namespace Shop.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {
            
        }
    }
}