using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoPooBanco.Domain.Entities;

namespace webapi.Domain.DTOs
{
    public class DepositoDTO
    {

        public Cliente Cliente { get; private set; }
        public ContaCorrente ContaCorrente { get; set; }
    }
}