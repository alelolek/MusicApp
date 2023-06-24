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
				id = dto.id,
				name = dto.name,
				urlImage = dto.urlImage,
			};
		}

		public ArtistDto MapEntityToDto(Artist artist)
		{
			return new ArtistDto
			{
				id = artist.id,
				name = artist.name,
				urlImage = artist.urlImage,
			};
		}
	}
}
