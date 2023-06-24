using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infraestructure.Entities;
using Infraestructure.Repositories;

namespace Presentation.View
{
	public partial class FormularioPrueba : Form
	{
		AccountRepository accountRepository = new AccountRepository();
		public FormularioPrueba()
		{
			InitializeComponent();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//// Agregar las columnas necesarias al DataGridView
			//dataGridView1.Columns.Add("id", "Id");
			//dataGridView1.Columns.Add("userName", "Nombre");
			//dataGridView1.Columns.Add("email", "Email");
			//dataGridView1.Columns.Add("rol", "Rol");
			//List<Account> accounts = accountRepository.GetAll();

			//// Limpiar el DataGridView antes de mostrar los datos
			//dataGridView1.Rows.Clear();

			//foreach (var account in accounts)
			//{
			//	// Agregar una fila al DataGridView con los datos de la cuenta
			//	dataGridView1.Rows.Add(account.id, account.username, account.email, account.rol);
			//}
		}

		private void MostrarUsuario()
		{


		}

		private void button1_Click(object sender, EventArgs e)
		{
			//// Agregar las columnas necesarias al DataGridView
			//dataGridView1.Columns.Add("id", "Id");
			//dataGridView1.Columns.Add("userName", "Nombre");
			//dataGridView1.Columns.Add("email", "Email");
			//dataGridView1.Columns.Add("rol", "Rol");
			//List<Account> accounts = objetoserv.GetAllAccounts();

			//// Limpiar el DataGridView antes de mostrar los datos
			//dataGridView1.Rows.Clear();

			//foreach (var account in accounts)
			//{
			//	// Agregar una fila al DataGridView con los datos de la cuenta
			//	dataGridView1.Rows.Add(account.id, account.userName, account.email, account.rol);
			//}
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
