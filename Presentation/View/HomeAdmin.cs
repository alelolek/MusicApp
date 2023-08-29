

using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using Infraestructure.Entities;
using Infraestructure.Repositories;
using System.Windows.Forms;

namespace Presentation.View
{

	public partial class HomeAdmin : Form
	{

		private IAccountService accountService;
		public HomeAdmin()
		{
			InitializeComponent();
			accountService = new AccountService();
		}
		public void addUserControl(UserControl userControl)
		{
			userControl.Dock = DockStyle.Fill;
			panelContainer.Controls.Clear();
			panelContainer.Controls.Add(userControl);
			userControl.BringToFront();
		}
		private void label3_Click(object sender, EventArgs e)
		{
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			UsersAdmin usersAdmin = new UsersAdmin();
			addUserControl(usersAdmin);

		}

		private void label5_Click(object sender, EventArgs e)
		{
			AlbumAdmin albumAdmin = new AlbumAdmin();
			addUserControl(albumAdmin);
		}

		private void label6_Click(object sender, EventArgs e)
		{
			ArtistAdmin artistAdmin = new ArtistAdmin();
			addUserControl(artistAdmin);
		}

		private void label7_Click(object sender, EventArgs e)
		{
			CategoryAdmin categoryAdmin = new CategoryAdmin();
			addUserControl(categoryAdmin);
		}

		private void label9_Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resultado == DialogResult.Yes)
			{
				this.Close();
				Login login = new Login();
				login.ShowDialog();
			}
		}

		private void HomeAdmin_Load(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Close();
			UsersAdmin usersAdmin = new UsersAdmin();
			addUserControl(usersAdmin);
		}



		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			UsersAdmin usersAdmin = new UsersAdmin();
			addUserControl(usersAdmin);
		}

		private void btnAlbum_Click(object sender, EventArgs e)
		{
			AlbumAdmin albumAdmin = new AlbumAdmin();
			addUserControl(albumAdmin);
		}

		private void btnArtist_Click(object sender, EventArgs e)
		{
			ArtistAdmin artistAdmin = new ArtistAdmin();
			addUserControl(artistAdmin);
		}

		private void btnCategory_Click(object sender, EventArgs e)
		{
			CategoryAdmin categoryAdmin = new CategoryAdmin();
			addUserControl(categoryAdmin);
		}

		private void btnSong_Click(object sender, EventArgs e)
		{
			SongAdmin song = new SongAdmin();
			addUserControl(song);
		}


	}
}
