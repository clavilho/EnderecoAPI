using Endereco.Domain.Core.Repositorio;
using Endereco.Domain.Core.Service;
using Endereco.Domain.Entidades;

namespace Endereco.Domain.Services.Service
{
    internal class EnderecoService : ServiceBase<Enderecos>, IServiceEndereco
    {
        private readonly IRepositorioEndereco _repositorio;
        public EnderecoService(IRepositorioEndereco repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
