using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoPooBanco.Domain.Entities;

namespace webapi.Domain.DTOs
{
    public class TransferenciaDTO
    {
        public int IdTransferencia { get; set; }
        public Cliente De { get; private set; }
        public Cliente Para { get; private set; }
    }
}