using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class Core
    {
        public Guid Id { get; set; }
        public DateTime Inclusao { get; set; }
        public DateTime Alteracao { get; set; }
        public bool Excluido { get; set; }
        public bool Sincronizado { get; set; }
    }
}
