using MrChens.Data.Models;
using System.Data.Entity;


namespace MrChens.Data.ORM.Context
{
    public class MrChensContext : DbContext
{
    public DbSet<Finance> Finances { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    }

}
