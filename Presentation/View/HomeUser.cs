using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.View
{
	public partial class HomeUser : Form
	{
		public HomeUser()
		{
			InitializeComponent();
			Home home = new Home();
			addUserControl(home);
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
			addUserControl(forYou);
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Home home = new Home();
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
	}
}