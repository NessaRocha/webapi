using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoPooBanco.Domain.Entities;

namespace webapi.Domain.DTOs
{
    public class PessoaDTO
    {

        public string Nome { get; set; }
        public string CPF { get; protected set; }
        public ESexo Sexo { get; protected set; }
    }
}