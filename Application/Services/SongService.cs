﻿using Business.Interface;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Infraestructure.Interface;
using Infraestructure.Repositories;
using Service.Implementations;
using Service.Interfaces;

namespace Business.Services
{
	public class SongService : ISongService
	{
		private readonly IRepository<SongDto> songRepository;
		private readonly ISongsService songsService;

		public SongService()
        {
			songRepository = new SongRepository();
			songsService = new SongsService();
		}

		public ResponseDto CreateSong(SongDto songDto)
		{
			var url = songsService.GuardarComoMp3(songDto.Song, songDto);
			songDto.UrlSong = url;
			var response = songRepository.Save(songDto);
			return response;
		}

		public ResponseDto DeleteSong(int songId)
		{
			var response = new ResponseDto();
			try
			{
				response = songRepository.Delete(songId);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public ResponseDto EditSong(SongDto songDto)
		{
			var response = new ResponseDto();
			try
			{
				response = songRepository.Update(songDto);
			}
			catch (Exception ex)
			{

				response.Errors.Add(string.Empty, ex.Message.Substring(0, Math.Min(ex.Message.Length, 250)));
			}
			return response;
		}

		public List<SongDto> GetAllSong()
		{
			List<SongDto> song;
			try
			{
				song = songRepository.Get();
			}
			catch
			{
				throw;
			}
			return song;
		}
	}
}
