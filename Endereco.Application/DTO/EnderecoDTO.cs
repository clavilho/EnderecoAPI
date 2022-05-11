using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endereco.Application.DTO
{
    public class EnderecoDTO
    {
        public int CEP { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public int? Apartamento { get; set; }
    }
}

