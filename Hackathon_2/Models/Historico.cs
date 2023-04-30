using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class Historico : Core
    {
        public Guid AnimalId { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid AdaptacaoId { get; set; }
        public Guid VeterinarioId { get; set; }
    }
}
