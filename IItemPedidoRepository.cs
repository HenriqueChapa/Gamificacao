using System.Collections.Generic;
using Entidade.Model;

public interface IItemPedidoRepository
{
    ItemPedido ObterPorId(long id);
    IEnumerable<ItemPedido> ObterTodos();
    void Inserir(ItemPedido itemPedido);
    void Atualizar(ItemPedido itemPedido);
    void Excluir(long id);
}
