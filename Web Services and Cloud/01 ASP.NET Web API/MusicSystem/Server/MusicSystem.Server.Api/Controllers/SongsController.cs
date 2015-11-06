namespace MusicSystem.Server.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data.Models;
    using Data.Common.Repositories;
    using Models;

    public class SongsController : ApiController
    {
        private IRepository<Song> songsRepository;
        private IRepository<Album> albumsRepository;
        private IRepository<Artist> artistsRepository;

        public SongsController(
            IRepository<Song> songsRepository, 
            IRepository<Album> albumsRepository, 
            IRepository<Artist> artistsRepository)
        {
            this.songsRepository = songsRepository;
            this.albumsRepository = albumsRepository;
            this.artistsRepository = artistsRepository;
        }

        public IHttpActionResult Get()
        {
            var songs = this.songsRepository
                .All()
                .ProjectTo<SongResponseModel>()
                .ToList();

            return this.Ok(songs);
        }

        public IHttpActionResult Get(int? id)
        {
            if (id == null)
            {
                return this.BadRequest("Song id cannot be null");
            }

            var songFromDb = this.songsRepository
                .GetById(id.Value);

            if (songFromDb == null)
            {
                return this.NotFound();
            }

            var songForResponse = Mapper.Map<SongResponseModel>(songFromDb);
            return this.Ok(songForResponse);
        }

        public IHttpActionResult Post(SongRequestModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var albumFromDb = this.albumsRepository
                .All()
                .FirstOrDefault(a => a.Title == song.AlbumTitle);

            if (albumFromDb == null)
            {
                return this.BadRequest("Album not found");
            }

            var artistFromDb = this.artistsRepository
                .All()
                .FirstOrDefault(a => a.Name == song.ArtistName);

            if (artistFromDb == null)
            {
                return this.BadRequest("Artist not found");
            }

            var newSong = Mapper.Map<Song>(song);
            newSong.AlbumId = albumFromDb.Id;
            newSong.ArtistId = artistFromDb.Id;

            this.songsRepository.Add(newSong);
            this.songsRepository.SaveChanges();

            return this.Ok(newSong.Id);
        }
    }
}