using System.Collections.Generic;

namespace NetCoders.Madrugada.MVC.Domain.Entities
{
    public partial class TB_FICANTE
    {
        public TB_FICANTE()
        {
            this.TB_TELEFONE = new List<TB_TELEFONE>();
        }

        public int idFicante { get; set; }
        public string nmFicante { get; set; }
        public string dsObs { get; set; }
        public virtual ICollection<TB_TELEFONE> TB_TELEFONE { get; set; }
    }
}
