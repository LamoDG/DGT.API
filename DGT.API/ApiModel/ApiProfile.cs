using AutoMapper;
using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<InfraccionDto, Infraccion>();
            CreateMap<TipoInfraccionDto, TipoInfraccion>();
            CreateMap<VehiculoDto, Vehiculo>();
            CreateMap<VehiculoConductorDto, VehiculoConductor>();
            CreateMap<ConductorDto, Conductor>();
        }
    }
}
