using Endereco.Domain.Core.Repositorio;
using Endereco.Domain.Core.Service;
using System;
using System.Collections.Generic;

namespace Endereco.Domain.Services.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repositorio;

        public ServiceBase(IRepositorioBase<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(TEntity entity)
        {
            _repositorio.Adicionar(entity);
        }

        public void Atualizar(TEntity entity)
        {
            _repositorio.Atualizar(entity);
        }

        public TEntity PegarPorCep(int cep)
        {
            return _repositorio.PegarPorCep(cep);
        }

        public IEnumerable<TEntity> PegarTodos()
        {
            return _repositorio.PegarTodos();
        }

        public void Remover(TEntity entity)
        {
            _repositorio.Remover(entity);
        }
    }
}
