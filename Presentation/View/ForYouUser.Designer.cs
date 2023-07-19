namespace Presentation.View
{
	partial class ForYouUser
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
			flowLayoutPanel1 = new FlowLayoutPanel();
			lbId = new Label();
			SuspendLayout();
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label12.ForeColor = Color.FromArgb(17, 0, 118);
			label12.Location = new Point(261, 34);
			label12.Name = "label12";
			label12.Size = new Size(157, 37);
			label12.TabIndex = 3;
			label12.Text = "FOR YOU";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Location = new Point(67, 145);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(564, 405);
			flowLayoutPanel1.TabIndex = 5;
			// 
			// lbId
			// 
			lbId.AutoSize = true;
			lbId.ForeColor = Color.White;
			lbId.Location = new Point(71, 43);
			lbId.Name = "lbId";
			lbId.Size = new Size(38, 15);
			lbId.TabIndex = 6;
			lbId.Text = "label4";
			// 
			// ForYouUser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(lbId);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(label12);
			Name = "ForYouUser";
			Size = new Size(705, 650);
			Load += ForYouUser_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label12;
		private FlowLayoutPanel flowLayoutPanel1;
		public Label lbId;
	}
}
