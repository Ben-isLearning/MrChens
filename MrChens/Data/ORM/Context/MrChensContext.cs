using MrChens.Data.Models;
using System.Data.Entity;


namespace MrChens.Data.ORM.Context
{
    public class MrChensContext : DbContext, IMrChensContext
{
    public DbSet<Finance> Finances { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Customer> Customers { get; set; }
    }

}
