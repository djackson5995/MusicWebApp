using Microsoft.EntityFrameworkCore;
using MusicWebApp.Model;

namespace MusicWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)

        {
            
        }

        public void AddSongToDatabase()
        {
            var newSong = new Song
            {
                Id = 1,
                Title = "Passion Fruit",
                Genre = "Rap",
                Artist = "Drake",
                yearReleased = 2016
            };
            _ = new Song
            {
                Id = 2,
                Title = "XTC",
                Artist = "Che Ecru",
                Genre = "Rap",
                yearReleased = 2018
            };
            _ = new Song
            { 
                Id = 3,
                Title = "No Pole",
                Artist = "Don Toliver",
                Genre = "Rap",
                yearReleased = 2020

            };
            _ = new Song
            {
                Id = 4,
                Title = "No child left behind",
                Artist = "Yee",
                Genre = "Rap",
                yearReleased = 2019
            };
            _ = new Song
            {
                Id = 5,
                Title = " Waste Time Management",
                Artist = "Che Ecru",
                Genre = "Rap",
                yearReleased = 2021
            };
            _ = new Song
            {
                Id = 6,
                Title = "Euphoric",
                Artist = "Rohaan",
                Genre = "RnB",
                yearReleased = 2022

            };
        }
    }
}
