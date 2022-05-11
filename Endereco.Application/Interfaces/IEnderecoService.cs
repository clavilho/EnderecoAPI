using Endereco.Application.DTO;
using System.Collections;
using System.Collections.Generic;

namespace Endereco.Application.Interfaces
{
    public interface IEnderecoService
    {
        void AdicionarEndereco(EnderecoDTO endereco);
        void AtualizarEndereco(EnderecoDTO endereco);
        void RemoverEndereco(EnderecoDTO endereco);
        IEnumerable<EnderecoDTO> PegarTodosEnderecos();
        IEnumerable<EnderecoDTO> BuscarEnderecoPeloCep(int cep);
    }
}
