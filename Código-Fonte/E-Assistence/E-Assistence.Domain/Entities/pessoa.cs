using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Assistence.Domain.Entities
{
    public class Pessoa
    {
        public int PersonID { get; set; }
        public string NomePessoa { get; set; }
        public int NumeroTelefone { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int NumeroLogradouro { get; set; }
        public int Cep { get; set; }
        public string Email { get; set; }

    }
}
