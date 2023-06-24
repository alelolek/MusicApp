using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.Interface;
using Infraestructure.Repositories;

namespace Business.Services
{
	public class AlbumService
	{
		private readonly IRepository<AlbumDto> albumRepository;

		public AlbumService()
		{
			albumRepository = new AlbumRepository();
		}

		public ResponseDto CreateAlbum(AlbumDto albumDto)
		{
			var response = new ResponseDto();
			try
			{
				response = albumRepository.Save(albumDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto EditAlbum(AlbumDto albumDto)
		{
			var response = new ResponseDto();
			try
			{
				response = albumRepository.Update(albumDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto DeleteAlbum(AlbumDto albumDto)
		{
			var response = new ResponseDto();
			try
			{
				response = albumRepository.Delete(albumDto.id);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}
	}
}
