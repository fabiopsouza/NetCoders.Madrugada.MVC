using NetCoders.Madrugada.MVC.Domain.Entities;
using NetCoders.Madrugada.MVC.Domain.Interface;
using NetCoders.Madrugada.MVC.Services.Interface;

namespace NetCoders.Madrugada.MVC.Services.Services
{
    public class FicanteService : ServiceBase<TB_FICANTE>, IFicanteService
    {
        private readonly IFicanteRepository _ficanteRepository;

        public FicanteService(IFicanteRepository ficanteRepository) : base(ficanteRepository)
        {
            _ficanteRepository = ficanteRepository;
        }
    }
}
