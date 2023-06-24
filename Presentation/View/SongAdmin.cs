

namespace Presentation.View
{
	public partial class SongAdmin : UserControl
	{
		public SongAdmin()
		{
			InitializeComponent();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			

		}



		private void btnAddSong_Click(object sender, EventArgs e)
		{
			UploadSong us = new UploadSong();
			us.ShowDialog();
		}


	}
}
