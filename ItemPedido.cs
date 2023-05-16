using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Model
{
    public class ItemPedido
    {
        public long IdItem { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto? ProdutoPedido { get; set; }

    }
}