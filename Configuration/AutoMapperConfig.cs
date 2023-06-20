using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TrabalhoPooBanco.Domain.Entities;
using webapi.Domain.DTOs;
using webapi.Domain.ViewModels;

namespace webapi.Configuration
{
    public class AutoMapperDTOs : Profile
    {
        public AutoMapperDTOs()
        {
            CreateMap<Cliente, ClienteDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<ContaCorrente, ContaCorrenteDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<Conta, ContaDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<Deposito, DepositoDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<Pessoa, PessoaDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<Resultado, ResultadoDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<Saque, SaqueDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<Transacao, TransacaoDTO>().PreserveReferences().MaxDepth(0);
            CreateMap<Transferencia, TransferenciaDTO>().PreserveReferences().MaxDepth(0);

        }
    }

    public class AutoMapperViewModels : Profile
    {
        public AutoMapperViewModels()
        {
            CreateMap<ClienteViewModels, Cliente>();
            CreateMap<DepositoViewModels, Deposito>();
            CreateMap<PessoaViewModels, Pessoa>();
            CreateMap<ResultadoViewModels, Resultado>();
            CreateMap<SaqueViewModels, Saque>();
            CreateMap<TransacaoViewModels, Transacao>();
            CreateMap<TransferenciaViewModels, Transferencia>();
        }
    }
}