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
			label12 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label12.ForeColor = Color.FromArgb(17, 0, 118);
			label12.Location = new Point(280, 25);
			label12.Name = "label12";
			label12.Size = new Size(111, 37);
			label12.TabIndex = 4;
			label12.Text = "HOME";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Indigo;
			label1.Location = new Point(162, 165);
			label1.Name = "label1";
			label1.Size = new Size(364, 45);
			label1.TabIndex = 5;
			label1.Text = "BIENVENIDO USUARIO";
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(label1);
			Controls.Add(label12);
			Name = "Home";
			Size = new Size(705, 650);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label12;
		private Label label1;
	}
}
