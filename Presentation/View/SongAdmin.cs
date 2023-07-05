

using System.Windows.Forms;

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

		private void SongAdmin_Load(object sender, EventArgs e)
		{
			//// Crear una instancia de DataGridViewComboBoxColumn
			//DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
			//comboBoxColumn.HeaderText = "Opciones";

			//// Agregar opciones al ComboBox de la cabecera
			//comboBoxColumn.Items.Add("Opción 1");
			//comboBoxColumn.Items.Add("Opción 2");
			//comboBoxColumn.Items.Add("Opción 3");

			//// Agregar la columna al DataGridView
			//dgvSongs.Columns.Add(comboBoxColumn);
		}

		private void dgvSongs_SelectionChanged(object sender, EventArgs e)
		{

		}
	}
}
