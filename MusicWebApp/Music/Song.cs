using System.ComponentModel.DataAnnotations;

namespace MusicWebApp.Model
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }
        public int yearReleased { get; set; }

        
    }
}
