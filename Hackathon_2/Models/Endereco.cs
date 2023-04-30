using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class Endereco : Core
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}
