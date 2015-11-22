namespace Exam.Server.Api.Models.Games
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class GameResponseModel : IMapFrom<Game>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Blue { get; set; }

        public string Red { get; set; }

        public string GameState { get; set; }

        public DateTime DateCreated { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Game, GameResponseModel>()
                .ForMember(g => g.Blue, opt => opt.MapFrom(g => g.BluePlayer == null ? "No blue player yet" : g.BluePlayer.Email))
                .ForMember(g => g.Red, opt => opt.MapFrom(g => g.RedPlayer.Email))
                .ForMember(g => g.GameState, opt => opt.MapFrom(g => g.GameState.ToString()));
        }
    }
}