
using CrossCuting.DTO;

namespace Infraestructure.Entities
{
	public class Song
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string UrlImage { get; set; }
		public Artist Artist { get; set; }
		public Album Album { get; set; }
		public Category Category { get; set; }
	}
}
