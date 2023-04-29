using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class Usuario : Core
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string CR { get; set; } //Comprovante de residencia
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string EnderecoId { get; set; }
    }
}
