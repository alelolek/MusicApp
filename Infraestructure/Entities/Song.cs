

namespace Infraestructure.Entities
{
	public class Song
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Artist Artist { get; set; }
		public Album Album { get; set; }
		public Category Category { get; set; }
		public string UrlSong { get; set; }
	}
}
