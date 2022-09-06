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
    public class OdjelController : ControllerBase
    {
        private readonly IOdjelService _service;

        public OdjelController(IOdjelService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.Odjel> Get([FromQuery] OdjelSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Models.Odjel GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Models.Odjel Insert(OdjelInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Models.Odjel Update(int id, [FromBody] OdjelUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
