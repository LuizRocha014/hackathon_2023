using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class Veterinario : Core
    {
        public string Nome { get; set; }
        public string CFMV { get; set; }
        public string Especialidade { get; set; }
        public string Imagem { get; set; }
    }
}
