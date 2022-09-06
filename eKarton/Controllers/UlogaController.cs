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
    public class UlogaController : ControllerBase
    {
        private readonly IUlogaService _service;

        public UlogaController(IUlogaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Uloga> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        [Route("ProvjeriAdmin/{UlogaId}")]
        public Model.Models.Uloga ProvjeriAdmin(int UlogaId)
        {
            return _service.ProvjeriAdmin(UlogaId);
        }
    }
}
