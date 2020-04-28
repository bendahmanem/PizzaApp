using Microsoft.EntityFrameworkCore;
using PizzaApp.Database.Models;

namespace PizzaApp.Database.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        { }


        public DbSet<Adresses> Adresses { get; set; }
        public DbSet<BonLiv> BonLivs { get; set; }
        public DbSet<CataloguePizza> CataloguePizzas { get; set; }
        public DbSet<CdeCli> CdeClis { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DetailLiv> DetailLivs { get; set; }
        public DbSet<Fabrication> Fabrications{ get; set; }
        public DbSet<FactCliBonLiv> FactCliBonLivs { get; set; }
        public DbSet<LigneCdeCli> LigneCdeClis { get; set; }
        public DbSet<Livraison> Livraisons { get; set; }
        public DbSet<Livreur> Livreurs { get; set; }
        public DbSet<PaiementCli> PaiementClis { get; set; }
        public DbSet<Quartier> Quartiers { get; set; }

    }
}
