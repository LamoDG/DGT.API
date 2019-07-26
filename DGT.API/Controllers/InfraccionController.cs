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
    public class InfraccionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IInfraccionService _infraccionService;
        public InfraccionController(IMapper mapper, IInfraccionService infraccionService)
        {
            _mapper = mapper;
            _infraccionService = infraccionService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Crear(InfraccionDto infraccion)
        {
            await _infraccionService.Crear(_mapper.Map<Infraccion>(infraccion));
            return Ok();
        }
        [HttpGet]
        [Route("[action]/{DNI}")]
        public async Task<IActionResult> Historial(string DNI)
        {
            return Ok(await _infraccionService.InfraccionesConductor(DNI));
        }
    }
}