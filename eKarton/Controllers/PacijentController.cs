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
    public class PacijentController : ControllerBase
    {
        private readonly IPacijentService _service;

        public PacijentController(IPacijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Model.Models.Pacijent> Get([FromQuery] PacijentSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public void Insert(PacijentInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] PacijentUpdateRequest request)
        {
            _service.Update(id, request);
        }
        [HttpGet("{id}")]
        public Pacijent GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Model.Models.Pacijent Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }

    }
}
