using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Domain.DTOs
{
    public class ResultadoDTO
    {
        public required bool Status { get; set; }
        public required string Mensagem { get; set; }
    }
}