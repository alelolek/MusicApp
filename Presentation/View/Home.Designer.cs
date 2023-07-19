namespace Presentation.View
{
	partial class Home
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
			lbNombre = new Label();
			panelImages = new FlowLayoutPanel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Indigo;
			label1.Location = new Point(267, 16);
			label1.Name = "label1";
			label1.Size = new Size(176, 45);
			label1.TabIndex = 5;
			label1.Text = "WELCOME";
			// 
			// lbNombre
			// 
			lbNombre.AutoSize = true;
			lbNombre.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			lbNombre.ForeColor = Color.Indigo;
			lbNombre.Location = new Point(300, 61);
			lbNombre.Name = "lbNombre";
			lbNombre.Size = new Size(0, 45);
			lbNombre.TabIndex = 6;
			// 
			// panelImages
			// 
			panelImages.Location = new Point(44, 116);
			panelImages.Name = "panelImages";
			panelImages.Size = new Size(610, 434);
			panelImages.TabIndex = 7;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panelImages);
			Controls.Add(lbNombre);
			Controls.Add(label1);
			Name = "Home";
			Size = new Size(705, 650);
			Leave += Home_Leave;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label12;
		private Label label1;
		public Label lbNombre;
		private Panel panel1;
		private Label label2;
		private PictureBox pictureBox1;
		private Panel panel2;
		private Label label5;
		private PictureBox pictureBox5;
		private Panel panel3;
		private Label label3;
		private PictureBox pictureBox2;
		private Panel panel4;
		private Label label4;
		private PictureBox pictureBox3;
		private Panel panel5;
		private Label label6;
		private PictureBox pictureBox4;
		private Panel panel6;
		private Label label7;
		private PictureBox pictureBox6;
		private FlowLayoutPanel panelImages;
	}
}
