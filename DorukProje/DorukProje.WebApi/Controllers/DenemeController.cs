using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DorukProje.Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DorukProje.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class DenemeController : ControllerBase
    {
        private readonly IEmirService _emirService;
        public DenemeController(IEmirService emirService)
        {
            _emirService = emirService;
        }
        
        [HttpGet("{action}")]
        public IActionResult GetDurusListele() 
        {
            var data = _emirService.DurusListele();
            return Ok(data);
        }

        [HttpGet("{action}")]
        public IActionResult GetEmirListele()
        {
            var data = _emirService.EmirListele();
            return Ok(data);
        }

        [HttpGet("{action}")]
        public IActionResult GetRapor()
        {
            var data = _emirService.Rapor();
            return Ok(data);
        }
    }
}
