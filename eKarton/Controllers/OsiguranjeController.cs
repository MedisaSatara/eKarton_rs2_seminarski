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
    public class OsiguranjeController : ControllerBase
    {
        private readonly IOsiguranjeService _service;

        public OsiguranjeController(IOsiguranjeService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.Osiguranje> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.Models.Osiguranje GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet]
        [Route("ProvjeriOsiguranje/{OsiguranjeId}")]
        public Model.Models.Osiguranje ProvjeriOsiguranje(int OsiguranjeId)
        {
            return _service.ProvjeriOsiguranje(OsiguranjeId);
        }
    }
}
