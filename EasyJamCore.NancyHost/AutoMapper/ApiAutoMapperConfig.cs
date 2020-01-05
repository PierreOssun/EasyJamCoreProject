namespace EasyJamCore.NancyHost.AutoMapper
{
    using EasyJamCore.Common.DTO;
    using EasyJamCore.Common.Model;
    using global::AutoMapper;

    public class ApiAutoMapperConfig : Profile
    {
        public ApiAutoMapperConfig()
        {
            CreateMap<DancerModel, DancerDto>();
        }
    }
}
