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
				Id = dto.Id,
				Name = dto.Name,
				UrlImage = dto.UrlImage
			};	
		}

		public AlbumDto MapEntityToDto(Album album)
		{
			return new AlbumDto
			{
				Id = album.Id,
				Name = album.Name,
				UrlImage = album.UrlImage
			};
		}
	}
}
