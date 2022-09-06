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
    public class OsiguranjePacijentController : ControllerBase
    {
        private readonly IOsiguranjePacijentService _service;
        public OsiguranjePacijentController(IOsiguranjePacijentService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.PacijentOsiguranje> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public async Task<Model.Models.PacijentOsiguranje> Insert([FromBody] PacijentiOsiguranjeInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
