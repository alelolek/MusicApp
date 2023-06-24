using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.View
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Register viewRegister = new Register();
			viewRegister.Show();
		}

		private void textBox1_MouseLeave(object sender, EventArgs e)
		{
			if (tbUser.Text == "")
			{
				tbUser.Text = "Username";
				tbUser.ForeColor = System.Drawing.SystemColors.GrayText;
			}
		}

		private void tbUser_MouseEnter(object sender, EventArgs e)
		{
			if (tbUser.Text == "Username")
			{
				tbUser.Text = "";
				tbUser.ForeColor = System.Drawing.SystemColors.WindowText;
			}
		}

		private void textBox2_MouseLeave(object sender, EventArgs e)
		{
			if (tbPassword.Text == "")
			{
				tbPassword.Text = "Password";
				tbPassword.ForeColor = System.Drawing.SystemColors.GrayText;
			}
		}

		private void textBox2_MouseEnter(object sender, EventArgs e)
		{
			if (tbPassword.Text == "Password")
			{
				tbPassword.Text = "";
				tbPassword.ForeColor = System.Drawing.SystemColors.WindowText;
			}
		}
	}
}
