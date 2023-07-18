using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO;
using Infraestructure.Entities;
using Infraestructure.Interface;

namespace Infraestructure.Mapper
{
	public class SongMapper : IMapper<Song, SongDto>
	{
		public Song MapDtoToEntity(SongDto dto)
		{
			return new Song
			{
				Id = dto.Id,
				Name = dto.Name,
				Artist = new Artist{Id = dto.Artist.Id},
				Album = new Album{Id = dto.Album.Id},
				Category = new Category { Id = dto.Category.Id },
				UrlSong = dto.UrlSong,
			};
		}

		public SongDto MapEntityToDto(Song song)
		{
			return new SongDto
			{
				Id = song.Id,
				Name = song.Name,
				Artist = new ArtistDto 
				{
					Id = song.Artist.Id,
					Name = song.Artist.Name,
					UrlImage = song.Artist.UrlImage
				},
				Album = new AlbumDto 
				{
					Id = song.Album.Id,
					Name = song.Album.Name,
					UrlImage = song.Album.UrlImage
				},
				Category = new CategoryDto 
				{ 
					Id = song.Category.Id,
					Name = song.Category.Name
				},
				UrlSong = song.UrlSong,
			};



		}
	}
}
