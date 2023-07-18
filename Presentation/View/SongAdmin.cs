

using System.Windows.Forms;
using Business.Interface;
using Business.Services;

namespace Presentation.View
{
	public partial class SongAdmin : UserControl
	{
		private readonly ISongService songService;
		public SongAdmin()
		{
			InitializeComponent();
			songService = new SongService();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{


		}

		private void btnAddSong_Click(object sender, EventArgs e)
		{
			UploadSong us = new UploadSong();
			us.ShowDialog();
		}

		private void SongAdmin_Load(object sender, EventArgs e)
		{
			dgvSongs.Columns.Add("id", "Id");
			dgvSongs.Columns.Add("name", "Name");
			RecargarGrid();
		}
		private void RecargarGrid()
		{
			dgvSongs.Rows.Clear();
			var response = songService.GetAllSong();
			foreach (var data in response)
			{
				dgvSongs.Rows.Add(data.Id, data.Name);
			}
		}

		private void dgvSongs_SelectionChanged(object sender, EventArgs e)
		{

		}
	}
}
