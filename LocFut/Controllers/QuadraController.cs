using LocFut.Application.Interface;
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
        protected readonly IQuadraService quadraService;
        public QuadraController(IQuadraService quadraService)
        {
            this.quadraService = quadraService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(quadraService.Get());
        }
    }
}
