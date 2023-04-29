using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class Animal : Core
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string RacaId { get; set; }
        public string Porte { get; set; }
        public string Sexo { get; set; }
        public string DtNacimento { get; set; }
        public string Obs { get; set; }
    }
}
