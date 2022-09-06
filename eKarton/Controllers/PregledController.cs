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
    public class PregledController : ControllerBase
    {
        private readonly IPregledService _service;

        public PregledController(IPregledService service)
        {
            _service = service;
        }
        [HttpGet]
        public virtual IEnumerable<Model.Models.Pregled> Get([FromQuery] PregledSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Pregled GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
