using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetCoders.Madrugada.MVC.Domain.Entities;

namespace NetCoders.Madrugada.MVC.DataAccess.Mapping
{
    public class TB_FICANTEMap : EntityTypeConfiguration<TB_FICANTE>
    {
        public TB_FICANTEMap()
        {
            // Primary Key
            this.HasKey(t => t.idFicante);

            // Properties
            this.Property(t => t.nmFicante)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.dsObs)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TB_FICANTE");
            this.Property(t => t.idFicante).HasColumnName("idFicante");
            this.Property(t => t.nmFicante).HasColumnName("nmFicante");
            this.Property(t => t.dsObs).HasColumnName("dsObs");
        }
    }
}
