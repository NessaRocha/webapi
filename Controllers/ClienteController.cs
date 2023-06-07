using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabalhoPooBanco.Data.Repositories;
using TrabalhoPooBanco.Domain.Entities;
using TrabalhoPooBanco.Domain.Interfaces;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;

        public ClienteController()
        {
            _repository = new ClienteRepository();
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _repository.GetAll();
        }
    }
}