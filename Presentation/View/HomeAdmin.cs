

using CrossCuting.DTO;
using Infraestructure.Entities;
using Infraestructure.Repositories;
using System.Windows.Forms;

namespace Presentation.View
{
	
	public partial class HomeAdmin : Form
	{
		AccountRepository accountRepository = new AccountRepository();
		AlbumRepository albumRepository = new AlbumRepository();
		public HomeAdmin()
		{
			InitializeComponent();
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
			SongAdmin song = new SongAdmin();
			addUserControl(song);

			DataGridView dgvSongs = song.dgvSongs;

			dgvSongs.Columns.Add("id", "Id");
			dgvSongs.Columns.Add("name", "Name Song");
			dgvSongs.Columns.Add("Artist", "Artist");
			dgvSongs.Columns.Add("Album", "Album");
			dgvSongs.Columns.Add("Category", "Category");


		}

		private void label4_Click(object sender, EventArgs e)
		{
			UsersAdmin usersAdmin = new UsersAdmin();
			addUserControl(usersAdmin);
			DataGridView dgv = usersAdmin.dataGridViewUsers;

			dgv.Columns.Add("id", "Id");
			dgv.Columns.Add("userName", "Nombre");
			dgv.Columns.Add("email", "Email");
			dgv.Columns.Add("rol", "Rol");
			List<AccountDto> accounts = accountRepository.GetAll();

			// Limpiar el DataGridView antes de mostrar los datos
			dgv.Rows.Clear();

			foreach (var account in accounts)
			{
				// Agregar una fila al DataGridView con los datos de la cuenta
				dgv.Rows.Add(account.id, account.username, account.email, account.rol);
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			AlbumAdmin albumAdmin = new AlbumAdmin();
			addUserControl(albumAdmin);

			DataGridView dgvAlbum = albumAdmin.dataGridViewAlbums;

			dgvAlbum.Columns.Add("id", "Id");
			dgvAlbum.Columns.Add("name", "Name");
			dgvAlbum.Columns.Add("urlImage", "Url Image");
			List<Album> albums = albumRepository.GetAll();

			dgvAlbum.Rows.Clear();

			foreach (var album in albums)
			{
				// Agregar una fila al DataGridView con los datos de la cuenta
				dgvAlbum.Rows.Add(album.id, album.name, album.urlImage);
			}
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
			}
		}
	}
}
