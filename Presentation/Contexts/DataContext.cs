using Microsoft.EntityFrameworkCore;
using Presentation.Entities;

namespace Presentation.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}
