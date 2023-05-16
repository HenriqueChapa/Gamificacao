using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Model
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string? NomeCliente { get; set; }
        public string? StatusPedido { get; set; }
        
    }
}