using System;
using Microsoft.EntityFrameworkCore;

namespace Lunch_app_demo.DbModels
{
    public class ModelContext: DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options):base(options)
        {
               
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
