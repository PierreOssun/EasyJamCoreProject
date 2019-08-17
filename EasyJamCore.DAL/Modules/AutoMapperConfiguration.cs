﻿using AutoMapper;
using EasyJamCore.Common.Model;
using EasyJamCore.DAL.Entities;

namespace EasyJamCore.DAL.Modules
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<DancerModel, DancerEntity>();
            CreateMap<BattleModel, BattleEntity>();
            CreateMap<BattleParticipantModel, BattleParticipantEntity>();
            CreateMap<BattlePreliminaryModel, BattlePreliminaryEntity>();
            CreateMap<BattleRoundModel, BattleRoundEntity>();
            CreateMap<CityModel, CityEntity>();
            CreateMap<CountryModel, CountryEntity>();
            CreateMap<CrewModel, CrewEntity>();
            CreateMap<DjModel, DjEntity>();
            CreateMap<HostModel, HostEntity>();
            CreateMap<JamModel, JamEntity>();
            CreateMap<JudgeModel, JudgeEntity>();
            CreateMap<SpeakerModel, SpeakerEntity>();
        }
    }
}