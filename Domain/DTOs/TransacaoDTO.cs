using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Domain.DTOs
{
    public class TransacaoDTO
    {
        public decimal Valor { get; protected set; }
        [Key]
        public int IdTransacoes { get; set; }
    }
}