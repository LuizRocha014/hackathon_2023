using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class ong : Core
    {
        public Guid EnderecoId { get; set; }
        public Guid VeterinarioId { get; set; }
        public string Nome { get; set; }
        public string Fundacao { get; set; }
    }
}
