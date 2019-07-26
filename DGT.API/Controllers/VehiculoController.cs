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
    public class VehiculoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVehiculoService _vehiculoService;
        public VehiculoController(IMapper mapper, IVehiculoService vehiculoService)
        {
            _mapper = mapper;
            _vehiculoService = vehiculoService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Crear(VehiculoDto vehiculo)
        {
            await _vehiculoService.Crear(_mapper.Map<Vehiculo>(vehiculo));
            return Ok();
        }
    }
}