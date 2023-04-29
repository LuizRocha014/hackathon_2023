using System;
using System.Collections.Generic;
using System.Text;

namespace Hackathon_2.Models
{
    public class Chat : Core
    {
        public Guid UsuarioId { get; set; }
        public Guid OngId { get; set; }
        public Guid VeterinarioId { get; set; }
        public string Mensagem { get; set; }
    }
}
