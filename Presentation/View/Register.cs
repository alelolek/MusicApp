using Business.Interface;
using Business.Services;
using CrossCuting.DTO;

namespace Presentation.View
{
	public partial class Register : Form
	{
		private IAccountService accountService;
		public Register()
		{
			InitializeComponent();
			accountService = new AccountService();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			OpenLogin();
		}

		private void OpenLogin()
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if(tbPassword.Text != txtPassPrueba.Text)
				{
					MessageBox.Show("Comprueba tu contraseña");
				}
				else if (tbUser.Text != null && tbEmail.Text != null && tbPassword.Text != null )
				{
					AccountDto account = new AccountDto()
					{
						username = tbUser.Text,
						email = tbEmail.Text,
						password = tbPassword.Text,
						rol = "Usuario",
					};

					var response = accountService.CreateAccount(account);
					MessageBox.Show("Registro Exitoso,\nInicia Sesion...");
					OpenLogin();
				}
				else
					MessageBox.Show("Campos Incompletos");
			}
			catch (Exception)
			{
				MessageBox.Show("Registro Invalido");
				throw;
			}
		}

		private void tbUser_Enter(object sender, EventArgs e)
		{
			if (tbUser.Text == "Username")
			{
				tbUser.Text = "";
				tbUser.ForeColor = Color.Black;
			}
		}

		private void tbUser_Leave(object sender, EventArgs e)
		{
			if (tbUser.Text == "")
			{
				tbUser.Text = "Username";
				tbUser.ForeColor = Color.LightGray;
			}
		}

		private void tbEmail_Leave(object sender, EventArgs e)
		{
			if (tbEmail.Text == "")
			{
				tbEmail.Text = "Email";
				tbEmail.ForeColor = Color.LightGray;
			}
		}

		private void tbEmail_Enter(object sender, EventArgs e)
		{
			if (tbEmail.Text == "Email")
			{
				tbEmail.Text = "";
				tbEmail.ForeColor = Color.Black;
			}
		}

		private void tbPassword_Leave(object sender, EventArgs e)
		{
			if (tbPassword.Text == "")
			{
				tbPassword.Text = "Password";
				tbPassword.ForeColor = Color.LightGray;
				tbPassword.UseSystemPasswordChar = false;
			}
		}

		private void tbPassword_Enter(object sender, EventArgs e)
		{
			if (tbPassword.Text == "Password")
			{
				tbPassword.Text = "";
				tbPassword.ForeColor = Color.Black;
				tbPassword.UseSystemPasswordChar = true;
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtPassPrueba_Leave(object sender, EventArgs e)
		{
			if (txtPassPrueba.Text == "")
			{
				txtPassPrueba.Text = "Repeat Password";
				txtPassPrueba.ForeColor = Color.LightGray;
				txtPassPrueba.UseSystemPasswordChar = false;
			}
		}

		private void txtPassPrueba_Enter(object sender, EventArgs e)
		{
			if (txtPassPrueba.Text == "Repeat Password")
			{
				txtPassPrueba.Text = "";
				txtPassPrueba.ForeColor = Color.Black;
				txtPassPrueba.UseSystemPasswordChar = true;
			}
		}
	}
}
