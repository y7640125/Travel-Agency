using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AutoMapperProfile : AutoMapper.Profile 
    { 
        public AutoMapperProfile()
        {
            CreateMap<FlightDTO, Flight>();
            CreateMap<Flight, FlightDTO>();
        }
    }
}
