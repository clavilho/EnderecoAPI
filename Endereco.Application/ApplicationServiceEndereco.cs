using AutoMapper;
using Endereco.Application.DTO;
using Endereco.Application.Interfaces;
using Endereco.Domain.Core.Service;
using Endereco.Domain.Entidades;
using System.Collections.Generic;

namespace Endereco.Application
{
    public class ApplicationServiceEndereco : IEnderecoService
    {
        private IServiceEndereco _servicoEndereco;
        private IMapper _mapper;

        public ApplicationServiceEndereco(IServiceEndereco serviceEndereco, IMapper mapper)
        {
            _servicoEndereco = serviceEndereco;
            _mapper = mapper;
        }

        public void AdicionarEndereco(EnderecoDTO endereco)
        {
            var enderecoNovo = _mapper.Map<Enderecos>(endereco);
            _servicoEndereco.Adicionar(enderecoNovo);
        }

        public void AtualizarEndereco(EnderecoDTO endereco)
        {
            var enderecoAtualizado = _mapper.Map<Enderecos>(endereco);
            _servicoEndereco.Atualizar(enderecoAtualizado);
        }

        public IEnumerable<EnderecoDTO> BuscarEnderecoPeloCep(int cep)
        {
            var endereco = _servicoEndereco.PegarPorCep(cep);
            var buscadorPorCep = _mapper.Map<IEnumerable<EnderecoDTO>>(endereco);

            return buscadorPorCep;
        }

        public IEnumerable<EnderecoDTO> PegarTodosEnderecos()
        {
            var enderecoTodos = _servicoEndereco.PegarTodos();
            var enderecoBuscado = _mapper.Map<IEnumerable<EnderecoDTO>>(enderecoTodos);

            return enderecoBuscado;
        }

        public void RemoverEndereco(EnderecoDTO EnderecoDto)
        {
            var enderecoExcluido = _mapper.Map<Enderecos>(EnderecoDto);
            _servicoEndereco.Remover(enderecoExcluido);
        }
    }
}
