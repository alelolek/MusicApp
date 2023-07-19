using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using Infraestructure.Entities;
using WMPLib;

namespace Presentation.View
{
	public partial class MusicPlayer : Form
	{
		WindowsMediaPlayer player;
		private bool estadoActual = false;
		private readonly ISongService songService;
		private readonly IAlbumService albumService;
		private string mp3Url;
		private double currentPosition;
		private int currentIndex;
		private List<SongDto> songList;

		public MusicPlayer(List<SongDto> songList) //List<SongDto> songList
		{
			InitializeComponent();
			player = new WindowsMediaPlayer();
			button2.BackgroundImage = Properties.Resources.pausa__1_;
			button2.BackgroundImageLayout = ImageLayout.Center;
			songService = new SongService();
			albumService = new AlbumService();
			currentIndex = 0;
			this.songList = songList;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			StopMusic();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var songs = songService.GetAllSong();
			var song = songs.FirstOrDefault(a => a.Id == Convert.ToInt32(lbSong.Text));
			var mp3Url = song.UrlSong;

			if (estadoActual)
			{
				button2.BackgroundImage = Properties.Resources.pausa__1_;
				ResumeMusic();
				estadoActual = false;
			}
			else
			{
				button2.BackgroundImage = Properties.Resources.jugar;
				estadoActual = true;
				StopMusic();
			}
			button2.BackgroundImageLayout = ImageLayout.Center;
		}

		private void PlayMusic(string mp3Url)
		{
			player.URL = mp3Url;
			player.controls.play();
		}

		private void StopMusic()
		{
			player.controls.stop();
		}

		private void ResumeMusic()
		{
			player.controls.currentPosition = currentPosition;
			player.controls.play();
		}


		private void PauseMusic()
		{
			player.controls.pause();
		}

		private void MusicPlayer_Load(object sender, EventArgs e)
		{
			var songs = songService.GetAllSong();
			var song = songs.FirstOrDefault(a => a.Id == Convert.ToInt32(lbSong.Text));
			var mp3Url = song.UrlSong;
			PlayMusic(mp3Url);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RecorrerCanciones();
		}

		public void RecorrerCanciones()
		{
			var songUrls = songList.Select(a => a.UrlSong).ToList();

			if (!songUrls.Any())
			{
				MessageBox.Show("No hay canciones.");
				return;
			}

			PlayCurrentSong();

			currentIndex++;
			if (currentIndex >= songUrls.Count)
			{
				currentIndex = 0;
			}
		}

		private void PlayCurrentSong()
		{
			var songUrls = songList.Select(a => a.UrlSong).ToList();
			var song = songList.FirstOrDefault(a => a.UrlSong == songUrls[currentIndex]);

			var albums = albumService.GetAllAlbums();
			var album = albums.FirstOrDefault(a => a.Id == song.Album.Id);

			if (songUrls.Count > 0 && currentIndex >= 0 && currentIndex < songUrls.Count)
			{
				string url = songUrls[currentIndex];
				player.URL = url;
				pbxImageSong.Image = ConvertirBytesAImagen(album.Photo);
				player.controls.play();
			}
		}

		public Image ConvertirBytesAImagen(byte[] imagenBytes)
		{
			using (MemoryStream ms = new MemoryStream(imagenBytes))
			{
				Image imagen = Image.FromStream(ms);
				return imagen;
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			RecorrerCanciones();
		}

		private void btnMoreVol_Click(object sender, EventArgs e)
		{
			if (player.settings.volume < 100)
			{
				player.settings.volume += 5;
			}
		}

		private void btnMenosVol_Click(object sender, EventArgs e)
		{
			if (player.settings.volume > 0)
			{
				player.settings.volume -= 5;
			}
		}
	}
}
