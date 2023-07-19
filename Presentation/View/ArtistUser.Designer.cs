namespace Presentation.View
{
	partial class ArtistUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistUser));
			label1 = new Label();
			txtBuscar = new TextBox();
			btnBuscar = new PictureBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(17, 0, 118);
			label1.Location = new Point(272, 35);
			label1.Name = "label1";
			label1.Size = new Size(131, 37);
			label1.TabIndex = 0;
			label1.Text = "ARTIST";
			// 
			// txtBuscar
			// 
			txtBuscar.BackColor = Color.White;
			txtBuscar.BorderStyle = BorderStyle.FixedSingle;
			txtBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			txtBuscar.ForeColor = Color.Black;
			txtBuscar.Location = new Point(399, 119);
			txtBuscar.Name = "txtBuscar";
			txtBuscar.Size = new Size(253, 33);
			txtBuscar.TabIndex = 1;
			txtBuscar.TextChanged += textBox1_TextChanged;
			// 
			// btnBuscar
			// 
			btnBuscar.BorderStyle = BorderStyle.FixedSingle;
			btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
			btnBuscar.Location = new Point(613, 119);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(39, 33);
			btnBuscar.SizeMode = PictureBoxSizeMode.CenterImage;
			btnBuscar.TabIndex = 3;
			btnBuscar.TabStop = false;
			btnBuscar.Click += pictureBox1_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(26, 174);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(644, 367);
			flowLayoutPanel1.TabIndex = 4;
			// 
			// ArtistUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(flowLayoutPanel1);
			Controls.Add(btnBuscar);
			Controls.Add(txtBuscar);
			Controls.Add(label1);
			Name = "ArtistUser";
			Size = new Size(705, 650);
			Load += ArtistUser_Load;
			((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtBuscar;
		private PictureBox btnBuscar;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}
