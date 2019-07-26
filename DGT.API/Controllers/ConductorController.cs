using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DGT.API.ApiModel;
using DGT.Domain.Models;
using DGT.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConductorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IConductorService _conductorService;
        public ConductorController(IConductorService conductorService, IMapper mapper)
        {
            _conductorService = conductorService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Crear(ConductorDto conductor)
        {
            await _conductorService.Crear(_mapper.Map<Conductor>(conductor));
            return Ok();
        }
    }
}