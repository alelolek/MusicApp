

using System.Windows.Forms;
using System.Xml.Linq;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO.Standar;

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

        public void Recargo()
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
            if (dgvSongs.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSongs.SelectedRows[0];

                string id = selectedRow.Cells["Id"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                //txtName.Text = name;
                txtId.Text = id;
                var intId = int.Parse(id);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //buscarKKC}
            Buscar();

        }
        public void Delete()
        {
            var songId = int.Parse(txtId.Text);
            var response = songService.DeleteSong(songId);
            if (response.Errors.Any())
            {
                foreach (var error in response.Errors)
                {
                    MessageBox.Show(error.Value);
                }
            }
            else
            {
                MessageBox.Show("Eliminado con éxito");
            }
        }
        public void Buscar()
        {
            string nombresong = txtBuscar.Text;

            var songs = songService.GetAllSong();
            var songEncontrado = songs.FirstOrDefault(a => a.Name.Contains(nombresong));

            if (songEncontrado != null)
            {

                dgvSongs.Rows.Clear();
                dgvSongs.Rows.Add(songEncontrado.Id, songEncontrado.Name);
            }
            else
            {
                MessageBox.Show("No se encontró ningún álbum con ese nombre.");
                dgvSongs.Rows.Clear();
                RecargarGrid();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Delete();
            
        }
    }
}
