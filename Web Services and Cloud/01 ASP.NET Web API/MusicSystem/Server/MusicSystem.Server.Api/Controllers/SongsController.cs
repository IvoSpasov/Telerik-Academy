namespace MusicSystem.Server.Api.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data.Common.Repositories;
    using Data.Models;
    using Models;
    using Services.Data.Interfaces;

    [EnableCors("*", "*", "*")]
    public class SongsController : ApiController
    {
        private ISongsService songsService;

        public SongsController(
            IRepository<Song> songsRepository,
            IRepository<Album> albumsRepository,
            IRepository<Artist> artistsRepository,
            ISongsService songsService)
        {
            this.songsService = songsService;
        }

        public IHttpActionResult Get()
        {
            var songs = this.songsService
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

            var songFromDb = this.songsService
                .SongById(id.Value);

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
                return this.BadRequest(this.ModelState);
            }

            int songId;

            try
            {
                songId = this.songsService.Add(
                    Mapper.Map<Song>(song),
                    song.AlbumTitle,
                    song.ArtistName);
            }
            catch (ArgumentException ex)
            {
                return this.BadRequest(ex.Message);
            }

            return this.Ok(songId);
        }

        public IHttpActionResult Put(int? id, SongRequestModel song)
        {
            if (id == null)
            {
                return this.BadRequest("Song id cannot be null");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            int songId;
            try
            {
                songId = this.songsService.Edit(id.Value, song.Title, song.Year, song.Genre, song.AlbumTitle, song.ArtistName);
            }
            catch (ArgumentException ex)
            {
                return this.BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return this.BadRequest(ex.Message);
            }

            return this.Ok(songId);
        }

        public IHttpActionResult Delete(int? id)
        {
            if (id == null)
            {
                return this.BadRequest("Song id cannot be null");
            }
            this.songsService.Delete(id.Value);

            return this.Ok();
        }
    }
}