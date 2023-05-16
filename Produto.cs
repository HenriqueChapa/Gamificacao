using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Model
{
    public class Produto
    {
        public long? ProdutoID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public double Preco { get; set; }
    }
    public class ItemPedido
    {
        public long IdItem { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto? ProdutoPedido { get; set; }

    }
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string? NomeCliente { get; set; }
        public string? StatusPedido { get; set; }

    }
}