

namespace CrossCuting.DTO
{
	public class SongDto
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public string UrlImage { get; set; }
        public ArtistDto Artist { get; set; }
        public AlbumDto Album{ get; set; }
        public CategoryDto Category { get; set; }
    }

    //public class Programa
    //{
    //    public static void Main()
    //    //{
    //    //    SongDto song = new SongDto();
    //    //    song.nombre = string.Empty;

    //    //    ArtistDto artist = new ArtistDto();
    //    //    artist.id = 1;

    //    //    song.Artist = artist;
    //    }
    //}
}
