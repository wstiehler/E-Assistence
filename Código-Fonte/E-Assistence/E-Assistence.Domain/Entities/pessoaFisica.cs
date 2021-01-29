using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Assistence.Domain.Entities
{
    public class PessoaFisica : Pessoa
    {
        public string Sobrenome { get; set; }
        public int Cpf { get; set; }
        public int DataNascimento { get; set; }
        public string Sexo { get; set; }
    }

  
}
