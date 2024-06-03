using Microsoft.EntityFrameworkCore;
using HuperFinance.Core.Models;
using HuperFinance.Api.Data.Mappings;
using System.Reflection;

namespace HuperFinance.Api.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt)
            : base(opt) 
        {
                
        }
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Used for each model to apply
            //modelBuilder.ApplyConfiguration(new CategoryMapping());
            //modelBuilder.ApplyConfiguration(new TransationMapping());

            //Apply for ALL model. NOT possible to explude one or more model(s)
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
