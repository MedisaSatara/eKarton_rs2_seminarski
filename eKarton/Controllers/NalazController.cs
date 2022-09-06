using eKarton.Model.Models;
using eKarton.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NalazController : ControllerBase
    {
        private readonly INalazService _service;

        public NalazController(INalazService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Nalaz> Get([FromQuery] NalazSearchRequest request = null)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Nalaz GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
