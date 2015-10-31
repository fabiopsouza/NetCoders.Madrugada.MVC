using System.Data.Entity;
using NetCoders.Madrugada.MVC.DataAccess.Mapping;
using NetCoders.Madrugada.MVC.Domain.Entities;

namespace NetCoders.Madrugada.MVC.DataAccess.Context
{
    public partial class SisTinderContext : DbContext
    {
        static SisTinderContext()
        {
            Database.SetInitializer<SisTinderContext>(null);
        }

        public SisTinderContext()
            : base("Name=SisTinderContext")
        {
            Configuration.ProxyCreationEnabled = false; //Obriga o EF trazer apenas o que foi pedido, e não fazer joins desnecessários
        }

        public DbSet<TB_FICANTE> TB_FICANTE { get; set; }
        public DbSet<TB_TELEFONE> TB_TELEFONE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TB_FICANTEMap());
            modelBuilder.Configurations.Add(new TB_TELEFONEMap());
        }
    }
}
