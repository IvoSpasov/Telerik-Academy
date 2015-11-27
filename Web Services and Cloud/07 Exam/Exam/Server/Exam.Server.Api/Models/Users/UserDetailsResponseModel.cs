namespace Exam.Server.Api.Models.Users
{
    using System;
    using System.Linq;
    using AutoMapper;
    using Exam.Data.Models;
    using Exam.Server.Infrastructure.Mapping;

    public class UserDetailsResponseModel : IMapFrom<User>, IHaveCustomMappings
    {
        public string UserName { get; set; }

        public int RealEstates { get; set; }

        public int Comments { get; set; }

        public double Rating { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<User, UserDetailsResponseModel>()
                .ForMember(u => u.RealEstates, opt => opt.MapFrom(u => u.RealEstates.Count))
                .ForMember(u => u.Comments, opt => opt.MapFrom(u => u.Comments.Count));
        }
    }
}