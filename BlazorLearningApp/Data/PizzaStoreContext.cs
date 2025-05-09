using BlazorLearningApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorLearningApp.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}    