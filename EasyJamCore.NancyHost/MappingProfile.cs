namespace EasyJamCore.NancyHost
{
    using AutoMapper;
    using EasyJamCore.Common.Model;
    using EasyJamCore.DAL.Entities;

    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DancerEntity, DancerModel>();
        }
    }
}