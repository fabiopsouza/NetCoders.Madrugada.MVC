using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoders.Madrugada.MVC.UI.WEB.ViewModel
{
    public class TelefoneViewModel
    {
        public int idTelefone { get; set; }
        public int idFicante { get; set; }
        public string nrTelefone { get; set; }
        public virtual FicanteViewModel TB_FICANTE { get; set; }
    }
}