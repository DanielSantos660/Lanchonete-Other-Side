using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete_Other_Side
{
    public class ItemPedido
    {
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public int pedido { get; set; }

        public double PrecoFinal
        {
            get
            {
                return PrecoUnitario * Quantidade;
            }
        }
    }
}
