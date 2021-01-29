using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Assistence.Domain.Entities
{
    public class Estoque
    {
        public int StockID { get; set; }
        public string NomePeca { get; set; }
        public decimal ValorPeca { get; set; }
        public int QuantidadePeca { get; set; }
        public string ModeloCompativel { get; set; }
        public string Cor { get; set; }
        public string CondicaoPeca { get; set; }
    }

   
}
