using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
