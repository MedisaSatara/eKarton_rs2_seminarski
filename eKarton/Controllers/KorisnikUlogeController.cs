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

    public class KorisnikUlogeController : ControllerBase
    {
        private readonly IKorisnikUlogeService _service;
        public KorisnikUlogeController(IKorisnikUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.KorisnikUloga> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public async Task<Model.Models.KorisnikUloga> Insert([FromBody] KorisnikUlogeInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
