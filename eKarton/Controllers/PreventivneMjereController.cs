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
    public class PreventivneMjereController : ControllerBase
    {
        private readonly IPreventivneMjereService _service;

        public PreventivneMjereController(IPreventivneMjereService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Model.Models.PreventivneMjere> Get(MjereSearchRequest request = null)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Models.PreventivneMjere GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
