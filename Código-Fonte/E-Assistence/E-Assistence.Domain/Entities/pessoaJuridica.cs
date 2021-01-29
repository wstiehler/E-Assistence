using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Assistence.Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }
        public int Cnpj { get; set; }
        public int InscricaoEstadual { get; set; }
    }
}
