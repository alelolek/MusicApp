using System.ComponentModel.DataAnnotations;
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;
using CrossCuting.DTO.Standar;
using Presentation.Validators;

namespace Presentation.View
{
	public partial class UsersAdmin : UserControl
	{
		private IAccountService accountService;

		public UsersAdmin()
		{
			InitializeComponent();
			accountService = new AccountService();
			cbxRole.Items.Add("Usuario");
			cbxRole.Items.Add("Administrador");
			cbxRole.SelectedIndex = 0;
		}


		public void Delete()
		{
			var response = new ResponseDto();
			var accountId = int.Parse(txtId.Text);
			response = accountService.DeleteAccount(accountId);

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
		public void Edit()
		{
			var response = new ResponseDto();
			try
			{
				var account = new AccountDto
				{
					id = int.Parse(txtId.Text),
					username = txtUsername.Text,
					email = txtEmail.Text,
					password = txtPassword.Text,
					rol = cbxRole.SelectedItem.ToString(),
				};
				response = accountService.EditAccount(account);
				MessageBox.Show("Actualizado con éxito");
			}
			catch (Exception)
			{
				if (response.Errors.Any())
				{
					foreach (var error in response.Errors)
					{
						MessageBox.Show(error.Value);
					}
				}
				else
				{
					MessageBox.Show("Act");
				}
			}
		}
		public void Guardar()
		{
			bool camposVacios = Validation.CamposVacios(txtUsername, txtEmail, cbxRole);

			if (camposVacios)
			{
				MessageBox.Show("Por favor, complete todos los campos obligatorios.");
				return;
			}

			var account = new AccountDto
			{
				username = txtUsername.Text,
				email = txtEmail.Text,
				rol = cbxRole.SelectedItem.ToString(),
				password = "contraGlobal",
			};

			var response = accountService.CreateAccount(account);

			if (response.Errors.Any())
			{
				foreach (var error in response.Errors)
				{
					MessageBox.Show(error.Value);
				}
			}
			else
			{
				MessageBox.Show("Registrado con éxito");
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Guardar();
			dataGridViewUsers.Refresh();
		}

		private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewUsers.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];

				string id = selectedRow.Cells["id"].Value.ToString();
				string username = selectedRow.Cells["Username"].Value.ToString();
				string email = selectedRow.Cells["Email"].Value.ToString();
				string rol = selectedRow.Cells["Rol"].Value.ToString();

				txtUsername.Text = username;
				txtEmail.Text = email;
				cbxRole.SelectedItem = rol;
				txtId.Text = id;
			}
		}

		private void UsersAdmin_Load(object sender, EventArgs e)
		{
			dataGridViewUsers.Columns.Add("id", "Id");
			dataGridViewUsers.Columns.Add("userName", "Nombre");
			dataGridViewUsers.Columns.Add("email", "Email");
			dataGridViewUsers.Columns.Add("rol", "Rol");

			RecargarGrid();
		}

		private void RecargarGrid()
		{
			dataGridViewUsers.Rows.Clear();
			var response = accountService.GetAllAccount();
			foreach (var data in response)
			{
				dataGridViewUsers.Rows.Add(data.id, data.username, data.email, data.rol);
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Edit();
			LimpiarCampos();
			RecargarGrid();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Delete();
			LimpiarCampos();
			RecargarGrid();
		}

		private void LimpiarCampos()
		{
			txtId.Clear();
			txtUsername.Clear();
			txtEmail.Clear();
			txtPassword.Clear();
			cbxRole.SelectedIndex = 0;
		}
	}
}
