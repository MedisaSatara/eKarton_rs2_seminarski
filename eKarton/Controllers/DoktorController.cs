using eKarton.Model.Models;
using eKarton.Model.Request;
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
    public class DoktorController : ControllerBase
    {
        private readonly IDoktorService _service;

        public DoktorController(IDoktorService service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual IEnumerable<Doktor> Get([FromQuery] DoktorSearchRequest request = null)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Doktor GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
