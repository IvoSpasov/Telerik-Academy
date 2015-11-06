namespace MusicSystem.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using Data.Common.Repositories;
    using Models;

    public class SongsController : ApiController
    {
        private IRepository<Song> songsRepository;

        public SongsController(IRepository<Song> songsRepository)
        {
            this.songsRepository = songsRepository;
        }

        public IHttpActionResult Get()
        {
            var songs = this.songsRepository
                .All()
                .ProjectTo<SongResponseModel>()
                .ToList();

            return this.Ok(songs);
        }
    }
}