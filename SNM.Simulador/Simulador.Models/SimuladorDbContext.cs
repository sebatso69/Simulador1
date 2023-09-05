using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Models
{
    public class SimuladorDbContext : DbContext
    {
        public SimuladorDbContext() : base("name=Simulador")
        {
        }

        public DbSet<APIToken> APITokens { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //DESCOMENTAR -> Add-Migration -> updatedb -> Ejecutar insert sin identity -> COMENTAR NUEVAMENTE -> Add-Migration -> updatedb -> fin
            //modelBuilder.Entity<NombreEntidad>().Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);base.OnModelCreating(modelBuilder);
        }
    }
}
