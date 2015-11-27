namespace Exam.Server.Api.Models.Comments
{
    using System;
    using AutoMapper;
    using Exam.Data.Models;
    using Exam.Server.Infrastructure.Mapping;

    public class CommentResponseModel : IMapFrom<Comment>, IHaveCustomMappings
    {
        public string Content { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Comment, CommentResponseModel>()
                .ForMember(c => c.UserName, opts => opts.MapFrom(c => c.User.UserName));
        }
    }
}