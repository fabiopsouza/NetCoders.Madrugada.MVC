using System;
using System.Collections.Generic;

namespace NetCoders.Madrugada.MVC.Domain.Entities
{
    public partial class TB_TELEFONE
    {
        public int idTelefone { get; set; }
        public int idFicante { get; set; }
        public string nrTelefone { get; set; }
        public virtual TB_FICANTE TB_FICANTE { get; set; }
    }
}
