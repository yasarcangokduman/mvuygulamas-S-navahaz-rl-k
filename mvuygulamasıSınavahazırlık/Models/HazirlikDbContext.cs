using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace mvuygulamasıSınavahazırlık.Models
{
    public class HazirlikDbContext : DbContext
    {
        string baglantiCümlesi = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HazirlikDb;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(baglantiCümlesi);
        }
       public DbSet<Ogrenci> Ogrenciler {  get; set; }
       public  DbSet<Sinif>Siniflar {  get; set; }
    }
}
