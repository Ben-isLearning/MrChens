using MrChens.Data.Models;
using System.Data.Entity;


namespace MrChens.Data.ORM.Context
{
    public class MrChensContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    }

}
