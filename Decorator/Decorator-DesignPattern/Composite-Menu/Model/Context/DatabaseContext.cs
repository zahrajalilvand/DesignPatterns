using Composite_Menu.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Composite_Menu.Model.Context
{
    public class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"DataSource=.;Initial Catalog=CompositDB;Integrated Security=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CategoryComponent> categoryComponents { get; set; }
        private DbSet<Category> categories { get; set; }
        private DbSet<CategoryItem> categoryItems { get; set; }

        //public DbSet<Product> products { get; set; }
    }
}
