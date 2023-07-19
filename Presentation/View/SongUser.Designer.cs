namespace Presentation.View
{
	partial class SongUser
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
			label1 = new Label();
			txtBuscar = new TextBox();
			pictureBox1 = new PictureBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			lbId = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(280, 30);
			label1.Name = "label1";
			label1.Size = new Size(130, 37);
			label1.TabIndex = 1;
			label1.Text = "SONGS";
			// 
			// txtBuscar
			// 
			txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtBuscar.ForeColor = SystemColors.AppWorkspace;
			txtBuscar.Location = new Point(385, 114);
			txtBuscar.Name = "txtBuscar";
			txtBuscar.Size = new Size(253, 33);
			txtBuscar.TabIndex = 3;
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Image = Properties.Resources.busqueda__1_;
			pictureBox1.Location = new Point(592, 114);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(46, 33);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(81, 195);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(557, 334);
			flowLayoutPanel1.TabIndex = 5;
			// 
			// lbId
			// 
			lbId.AutoSize = true;
			lbId.ForeColor = Color.White;
			lbId.Location = new Point(27, 32);
			lbId.Name = "lbId";
			lbId.Size = new Size(38, 15);
			lbId.TabIndex = 6;
			lbId.Text = "label2";
			// 
			// SongUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(lbId);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(pictureBox1);
			Controls.Add(txtBuscar);
			Controls.Add(label1);
			Name = "SongUser";
			Size = new Size(705, 650);
			Load += SongUser_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private PictureBox pictureBox1;
		private FlowLayoutPanel flowLayoutPanel1;
		public Label lbId;
		private TextBox txtBuscar;
	}
}
