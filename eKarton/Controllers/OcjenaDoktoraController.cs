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
    public class OcjenaDoktoraController : ControllerBase
    {
        private readonly IOcjenaDoktora _service;
        public OcjenaDoktoraController(IOcjenaDoktora service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.OcjenaDokora> Get([FromQuery] OcjeneSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpPost]
        public async Task<Model.Models.OcjenaDokora> Insert([FromBody] OcjenaInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
