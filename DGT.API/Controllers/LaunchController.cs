using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchController : ControllerBase
    {


        private readonly DGT.Domain.Models.DGTContext _dGTContext;

        public LaunchController(Domain.Models.DGTContext dGTContext)
        {

            _dGTContext = dGTContext;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult MoqDb()
        {
            AddTestData();
            return Ok();
        }
        private void AddTestData()
        {
            var marca = new Domain.Models.MarcaCoche
            {
                Nombre = "Ford"
            };
            var marca2 = new Domain.Models.MarcaCoche
            {
                Nombre = "Seat"
            };
            _dGTContext.MarcasCoche.Add(marca);
            _dGTContext.MarcasCoche.Add(marca2);
            _dGTContext.SaveChanges();
        }
    }

}