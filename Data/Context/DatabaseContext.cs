using System.Data.Entity;
using WpfPlayground.Models;

namespace Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
