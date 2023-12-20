using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicWebApp.Data;
using MusicWebApp.Model;
using Org.BouncyCastle.Security.Certificates;
using System.Runtime.CompilerServices;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<Playlist
        [HttpGet]
        public IActionResult Get()
        {
            var playlist = _context.Songs.ToList();
            return StatusCode(200, playlist);

        }

        // GET api/<PlaylistController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var songs = _context.Songs.Find(id);
            if (songs == null)
            {
                return NotFound();
            }
            return Ok(songs);

        }

        // POST api/<PlaylistController>
        [HttpPost]
        public IActionResult Post([FromBody] Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return StatusCode(201, song);


        }

        // PUT api/<PlaylistController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Song updatedSong )
        {
            var songs = _context.Songs.Find(id);
            if (songs == null) return NotFound();
            songs.Title = updatedSong.Title;
            songs.Artist = updatedSong.Artist;
            songs.Album = updatedSong.Album;
            songs.ReleaseDate = updatedSong.ReleaseDate;
            songs.Genre = updatedSong.Genre;


            _context.SaveChanges();

            return StatusCode(200, songs);








        }

        //DELETE api/<PlaylistController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Find(id);

            if (song == null) return NotFound();
            
                _context.Songs.Remove(song);
                _context.SaveChanges();
                return NoContent();
            } 
        

        }
   
    }










