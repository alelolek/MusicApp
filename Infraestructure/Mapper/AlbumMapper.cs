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
	public class AlbumMapper : IMapper<Album, AlbumDto>
	{
		public Album MapDtoToEntity(AlbumDto dto)
		{
			return new Album
			{
				id = dto.id,
				name = dto.name,
				urlImage = dto.urlImage
			};	
		}

		public AlbumDto MapEntityToDto(Album album)
		{
			return new AlbumDto
			{
				id = album.id,
				name = album.name,
				urlImage = album.urlImage
			};
		}
	}
}
