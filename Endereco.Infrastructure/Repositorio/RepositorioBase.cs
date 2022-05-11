using Endereco.Domain.Core.Repositorio;
using System;
using System.Collections.Generic;

namespace Endereco.Infrastructure.Repositorio
{
    public class RepositorioBasee<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        private readonly SqlConnection _sqlConnection;

        public void Adicionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity PegarPorCep(int cep)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> PegarTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
