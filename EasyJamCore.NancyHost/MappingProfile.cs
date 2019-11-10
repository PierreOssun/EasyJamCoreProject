using AutoMapper;
using EasyJamCore.Common.Model;
using EasyJamCore.DAL.Entities;

namespace EasyJamCore.NancyHost
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DancerEntity, DancerModel>();
        }
    }
}