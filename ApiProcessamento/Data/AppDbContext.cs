using Microsoft.EntityFrameworkCore;
using Shared; 

namespace ApiProcessamento.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    
    public DbSet<SensorData> LeiturasUmidade { get; set; }
}