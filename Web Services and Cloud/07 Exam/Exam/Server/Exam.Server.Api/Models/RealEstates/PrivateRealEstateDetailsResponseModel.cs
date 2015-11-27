namespace Exam.Server.Api.Models.RealEstates
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using Exam.Data.Models;
    using Exam.Server.Infrastructure.Mapping;

    public class PrivateRealEstateDetailsResponseModel : PublicRealEstateDetailsResponseModel, IMapFrom<RealEstate>, IHaveCustomMappings
    {
        public string Contact { get; set; }

        public ICollection<Comment> Comments { get; set; }       

        public override void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<RealEstate, PrivateRealEstateDetailsResponseModel>()
                .ForMember(e => e.RealEstateType, opt => opt.MapFrom(e => e.RealEstateType.ToString()));
        }
    }
}