namespace Exam.Server.Api.Models.RealEstates
{
    using System;
    using AutoMapper;
    using Exam.Data.Models;
    using Exam.Server.Infrastructure.Mapping;

    public class PublicRealEstateDetailsResponseModel : IMapFrom<RealEstate>, IHaveCustomMappings
    {
        public DateTime CreatedOn { get; set; }

        public int ConstructionYear { get; set; }

        public string Address { get; set; }

        public string RealEstateType { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal RentingPrice { get; set; }

        public bool CanBeSold { get; set; }

        public bool CanBeRented { get; set; }

        public virtual void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<RealEstate, PublicRealEstateDetailsResponseModel>()
                .ForMember(e => e.RealEstateType, opt => opt.MapFrom(e => e.RealEstateType.ToString()));
        }
    }
}