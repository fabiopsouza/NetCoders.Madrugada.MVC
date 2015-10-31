using System.Data.Entity.ModelConfiguration;
using NetCoders.Madrugada.MVC.Domain.Entities;

namespace NetCoders.Madrugada.MVC.DataAccess.Mapping
{
    public class TB_TELEFONEMap : EntityTypeConfiguration<TB_TELEFONE>
    {
        public TB_TELEFONEMap()
        {
            // Primary Key
            this.HasKey(t => t.idTelefone);

            // Properties
            this.Property(t => t.nrTelefone)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("TB_TELEFONE");
            this.Property(t => t.idTelefone).HasColumnName("idTelefone");
            this.Property(t => t.idFicante).HasColumnName("idFicante");
            this.Property(t => t.nrTelefone).HasColumnName("nrTelefone");

            // Relationships
            this.HasRequired(t => t.TB_FICANTE)
                .WithMany(t => t.TB_TELEFONE)
                .HasForeignKey(d => d.idFicante);

        }
    }
}
