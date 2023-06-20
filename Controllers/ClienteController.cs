using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoPooBanco.Data.Repositories;
using TrabalhoPooBanco.Domain.Entities;
using TrabalhoPooBanco.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;

        private object _clienteRepository;

        private readonly IMapper _mapper;

        public ClienteController()
        {
            object clienteRepository = null;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _repository.GetAll();
        }
    }
}