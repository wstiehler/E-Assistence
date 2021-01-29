using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Assistence.Domain.Entities
{
    public class OrdemServico
    {
        public Pessoa Pessoa { get; set; }
        public Servico Servico { get; set; }
        public Estoque Estoque { get; set; }

        public int OrderServiceID { get; set; }
        public int CodigoOrdemServico { get; set; }
        public string NomeClienteProprietatio { get; set; }
        public string NomeEquipamento { get; set; }
        public string NumeroSerieEquipamento { get; set; }
        public string MarcaEquipamento { get; set; }
        public string ModeloEquipamento { get; set; }
        public string SenhaEquipamento { get; set; }
        public DateTime DataChegadaEquipamento { get; set; }
        public string DefeitoEquipamento { get; set; }
        public string AvariaEquipamento { get; set; }
        public string StatusAtualOrdemServico { get; set; }
    }
}
