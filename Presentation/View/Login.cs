
using Business.Interface;
using Business.Services;
using CrossCuting.DTO;

namespace Presentation.View
{
	public partial class Login : Form
	{
		private IAccountService accountService;
		public event EventHandler ButtonClick;
		public Login()
		{
			InitializeComponent();
			accountService = new AccountService();

		}

		private void label3_Click(object sender, EventArgs e)
		{
			Register viewRegister = new Register();
			viewRegister.Show();
			this.Hide();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			var response = accountService.GetAllAccount();
			HomeUser homeUser = new HomeUser();
			HomeAdmin homeAdmin = new HomeAdmin();

			AccountDto accountDto = response.FirstOrDefault(a => a.username == txtUser.Text);

			if (accountDto.username != null && accountDto.password == txtPassword.Text)
			{
				if (accountDto.rol == "Administrador")
					homeAdmin.Show();
				else
					homeUser.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
			}

		}

		private void tbUser_Enter(object sender, EventArgs e)
		{
			if (txtUser.Text == "Username")
			{
				txtUser.Text = "";
				txtUser.ForeColor = Color.Black;
			}
		}

		private void txtUser_Leave(object sender, EventArgs e)
		{
			if (txtUser.Text == "")
			{
				txtUser.Text = "Username";
				txtUser.ForeColor = Color.LightGray;
			}
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text == "Password")
			{
				txtPassword.Text = "";
				txtPassword.ForeColor = Color.Black;
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text == "")
			{
				txtPassword.Text = "Password";
				txtPassword.ForeColor = Color.LightGray;
				txtPassword.UseSystemPasswordChar = false;
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
