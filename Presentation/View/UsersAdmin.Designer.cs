namespace Presentation.View
{
	partial class UsersAdmin
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersAdmin));
			label1 = new Label();
			txtUsername = new TextBox();
			txtEmail = new TextBox();
			cbxRole = new ComboBox();
			textBox3 = new TextBox();
			pictureBox1 = new PictureBox();
			dataGridViewUsers = new DataGridView();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(282, 33);
			label1.Name = "label1";
			label1.Size = new Size(124, 37);
			label1.TabIndex = 3;
			label1.Text = "USERS";
			// 
			// txtUsername
			// 
			txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsername.Location = new Point(61, 123);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(216, 33);
			txtUsername.TabIndex = 4;
			// 
			// txtEmail
			// 
			txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtEmail.Location = new Point(61, 181);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(216, 33);
			txtEmail.TabIndex = 5;
			// 
			// cbxRole
			// 
			cbxRole.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			cbxRole.FormattingEnabled = true;
			cbxRole.Location = new Point(61, 243);
			cbxRole.Name = "cbxRole";
			cbxRole.Size = new Size(216, 33);
			cbxRole.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBox3.ForeColor = SystemColors.AppWorkspace;
			textBox3.Location = new Point(386, 243);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(255, 33);
			textBox3.TabIndex = 7;
			textBox3.Text = "Search";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(597, 243);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(44, 33);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			// 
			// dataGridViewUsers
			// 
			dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewUsers.Location = new Point(61, 296);
			dataGridViewUsers.Name = "dataGridViewUsers";
			dataGridViewUsers.RowTemplate.Height = 25;
			dataGridViewUsers.Size = new Size(580, 205);
			dataGridViewUsers.TabIndex = 9;
			dataGridViewUsers.CellClick += dataGridView1_CellClick;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(71, 113);
			label2.Name = "label2";
			label2.Size = new Size(69, 17);
			label2.TabIndex = 10;
			label2.Text = "Username";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(71, 172);
			label3.Name = "label3";
			label3.Size = new Size(42, 17);
			label3.TabIndex = 11;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(71, 233);
			label4.Name = "label4";
			label4.Size = new Size(35, 17);
			label4.TabIndex = 12;
			label4.Text = "Role";
			// 
			// pictureBox2
			// 
			pictureBox2.BorderStyle = BorderStyle.FixedSingle;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(386, 164);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(54, 50);
			pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox2.TabIndex = 13;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.BorderStyle = BorderStyle.FixedSingle;
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(489, 164);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(54, 50);
			pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox3.TabIndex = 14;
			pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(587, 164);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(54, 50);
			pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox4.TabIndex = 15;
			pictureBox4.TabStop = false;
			// 
			// UsersAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(dataGridViewUsers);
			Controls.Add(pictureBox1);
			Controls.Add(textBox3);
			Controls.Add(cbxRole);
			Controls.Add(txtEmail);
			Controls.Add(txtUsername);
			Controls.Add(label1);
			Name = "UsersAdmin";
			Size = new Size(705, 650);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtUsername;
		private TextBox txtEmail;
		private ComboBox cbxRole;
		private TextBox textBox3;
		private PictureBox pictureBox1;
		private Label label2;
		private Label label3;
		private Label label4;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		public DataGridView dataGridViewUsers;
	}
}
