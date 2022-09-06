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

    public class KorisnikController : ControllerBase
    {
        private readonly IKorisnikService _service;

        public KorisnikController(IKorisnikService service)
        {
            _service = service;
        }


        [HttpGet]
        public IEnumerable<Model.Models.Korisnik> Get([FromQuery] KorisnikSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public void Insert(KorisnikInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KorisnikUpdateRequest request)
        {
            _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Models.Korisnik GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Korisnik Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }
    }
}
