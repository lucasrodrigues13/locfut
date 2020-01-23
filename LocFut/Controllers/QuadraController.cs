using AutoMapper;
using LocFut.Application.Interface;
using LocFut.Domain;
using LocFut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocFut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuadraController : ControllerBase
    {
        protected readonly IMapper mapper;
        protected readonly IQuadraService quadraService;
        public QuadraController(IQuadraService quadraService, IMapper mapper)
        {
            this.quadraService = quadraService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(quadraService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(quadraService.Get(id));
        }

        [HttpPost]
        public IActionResult Post(QuadraModel quadra)
        {

            return Ok(quadraService.Post(mapper.Map<QuadraModel, Quadra>(quadra)));
        }

        [HttpPut]
        public IActionResult Put(Guid id, QuadraModel quadra)
        {
            return Ok(quadraService.Put(id, mapper.Map<QuadraModel, Quadra>(quadra)));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            quadraService.Delete(id);
            return Ok();
        }
    }
}
