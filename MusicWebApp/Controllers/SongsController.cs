using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicWebApp.Data;
using MusicWebApp.Model;
using System.Runtime.CompilerServices;

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
        public IActionResult Put(int id, [FromBody] Song song)
        {
            if (song == null)
            {
                return NotFound();
            }
            var songs = _context.Songs;
            if (songs == null)
            {
                return NotFound();
            }
            songs = songs;

            _context.SaveChanges();

            return StatusCode(200, song);








        }

        //DELETE api/<PlaylistController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var song = _context.Songs.Find(id);
            
                _context.Songs.Remove(song);
                _context.SaveChanges();
                return NoContent();
            } 
        

        }
   
    }










