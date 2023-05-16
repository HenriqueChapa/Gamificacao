using System.Collections.Generic;
using Entidade.Model;

namespace Entidade.Repositories
{
    public interface IPedidoRepository
    {
        Pedido ObterPorId(int id);
        IEnumerable<Pedido> ObterTodos();
        void Inserir(Pedido pedido);
        void Atualizar(Pedido pedido);
        void Excluir(int id);
    }
}
