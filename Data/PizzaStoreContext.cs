using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

// this class creates the db context used to register a db service
// the context allows for a controller that accesses the db
public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}