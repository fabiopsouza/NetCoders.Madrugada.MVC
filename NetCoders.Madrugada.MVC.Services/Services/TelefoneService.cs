using NetCoders.Madrugada.MVC.Domain.Entities;
using NetCoders.Madrugada.MVC.Domain.Interface;
using NetCoders.Madrugada.MVC.Services.Interface;

namespace NetCoders.Madrugada.MVC.Services.Services
{
    public class TelefoneService : ServiceBase<TB_TELEFONE>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository) : base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }
    }
}
