using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using Infraestructure.Entities;

namespace Presentation.View
{
	public partial class HomeUser : Form
	{
		private readonly IAccountService accountService;
		private AccountDto usuario;
		public HomeUser()
		{
			InitializeComponent();
			accountService = new AccountService();
			Home home = new Home();
			addUserControl(home);

			//AccountDto account = new AccountDto();
			//label1.Text = "hol2";
		}

		private void addUserControl(UserControl userControl)
		{
			userControl.Dock = DockStyle.Fill;
			panelContainer.Controls.Clear();
			panelContainer.Controls.Add(userControl);
			userControl.BringToFront();
		}
		private void label4_Click(object sender, EventArgs e)
		{
			ArtistUser artist = new ArtistUser();
			addUserControl(artist);
		}

		private void label5_Click(object sender, EventArgs e)
		{
			AlbumUser album = new AlbumUser();
			addUserControl(album);
		}

		private void label6_Click(object sender, EventArgs e)
		{

			SongUser song = new SongUser();
			Label label = song.lbId;
			label.Text = idAccount.Text;
			addUserControl(song);
		}

		private void label7_Click(object sender, EventArgs e)
		{
			CategoriesUser categories = new CategoriesUser();
			addUserControl(categories);
		}

		private void label10_Click(object sender, EventArgs e)
		{
			ForYouUser forYou = new ForYouUser();
			Label label = forYou.lbId;
			label.Text = idAccount.Text;
			addUserControl(forYou);
		}

		private void label9_Click(object sender, EventArgs e)
		{

			var usuarios = accountService.GetAllAccount();
			usuario = usuarios.FirstOrDefault(a => a.id == Convert.ToInt32(idAccount.Text));

			var texto = usuario.username;
			Home home = new Home();
			Label label = home.lbNombre;
			label.Text = texto;
			addUserControl(home);
		}

		private void label11_Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resultado == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void HomeUser_Load(object sender, EventArgs e)
		{
			var usuarios = accountService.GetAllAccount();
			usuario = usuarios.FirstOrDefault(a => a.id == Convert.ToInt32(idAccount.Text));

			user.Text = usuario.username;

			var texto = usuario.username;
			Home home = new Home();
			Label label = home.lbNombre;
			label.Text = texto;
			addUserControl(home);
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void panelContainer_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}