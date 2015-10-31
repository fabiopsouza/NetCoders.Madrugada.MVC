using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoders.Madrugada.MVC.UI.WEB.ViewModel
{
    public class FicanteViewModel
    {
        public FicanteViewModel()
        {
            this.TB_TELEFONE = new List<FicanteViewModel>();
        }

        public int idFicante { get; set; }
        public string nmFicante { get; set; }
        public string dsObs { get; set; }
        public virtual ICollection<FicanteViewModel> TB_TELEFONE { get; set; }
    }
}