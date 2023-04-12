using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Data;

namespace MockAssessment5b.Models
{
    public class DbUserContext : DbContext
    {
        public DbUserContext(DbContextOptions<DbUserContext> options) : base(options)
        {
        }
            public DbSet<UserDetail> UserDetails{get; set; }
    }
    }

