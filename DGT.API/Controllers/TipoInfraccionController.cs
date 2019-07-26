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
    public class TipoInfraccionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITipoInfraccionService _tipoInfraccionService;
        public TipoInfraccionController(IMapper mapper, ITipoInfraccionService tipoInfraccionService)
        {
            _mapper = mapper;
            _tipoInfraccionService = tipoInfraccionService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Crear(TipoInfraccionDto tipoInfraccion)
        {
            await _tipoInfraccionService.Crear(_mapper.Map<TipoInfraccion>(tipoInfraccion));
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(await _tipoInfraccionService.GetAll());
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Top5InfraccionesHabituales()
        {

            return Ok(await _tipoInfraccionService.Top5InfraccionesHabituales());
        }
    }
}