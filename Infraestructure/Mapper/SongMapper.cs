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
				UrlImage = dto.UrlImage,
				Artist = dto.Artist,

			};
		}

		public SongDto MapEntityToDto(Song song)
		{
			throw new NotImplementedException();
		}
	}
}
