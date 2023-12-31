﻿using AutoMapper;

namespace Mike.Interface.Mapper
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            return new MapperConfiguration(x =>
            {
                x.AddProfile(new MappingProfile());
            });
        }
    }
}
