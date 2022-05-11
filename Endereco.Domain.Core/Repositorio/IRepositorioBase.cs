using System.Collections.Generic;

namespace Endereco.Domain.Core.Repositorio
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);

        void Remover(TEntity entity);

        IEnumerable<TEntity> PegarTodos();

        TEntity PegarPorCep(int cep);
    }
}
