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
	public class ArtistMapper : IMapper<Artist, ArtistDto>
	{
		public Artist MapDtoToEntity(ArtistDto dto)
		{
			return new Artist
			{
				Id = dto.Id,
				Name = dto.Name,
				UrlImage = dto.UrlImage,
			};
		}

		public ArtistDto MapEntityToDto(Artist artist)
		{
			return new ArtistDto
			{
				Id = artist.Id,
				Name = artist.Name,
				UrlImage = artist.UrlImage,
			};
		}
	}
}
