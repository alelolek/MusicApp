using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO.Standar;
using CrossCuting.DTO;
using Infraestructure.Repositories;

namespace Business.Interface
{
	public interface IArtistService
	{
		public ResponseDto CreateArtist(ArtistDto artistDto);

		public ResponseDto EditArtist(ArtistDto artistDto);

		public ResponseDto DeleteArtist(int artistId);
		public List<ArtistDto> GetAllArtist();
	}
}
