

namespace CrossCuting.DTO
{
	public class SongDto
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public ArtistDto Artist { get; set; }
        public AlbumDto Album { get; set; }
        public CategoryDto Category { get; set; }
		public string UrlSong { get; set; }
		public byte[] Song { get; set; }
	}
}
