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
            pictureBox7 = new PictureBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
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
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.ms1;
            pictureBox7.Location = new Point(53, 158);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(607, 334);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(44, 541);
            label9.Name = "label9";
            label9.Size = new Size(635, 20);
            label9.TabIndex = 3;
            label9.Text = "Enciende el ritmo y déjate llevar por la magia de la música en la palma de tu mano.";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox7);
            Controls.Add(lbNombre);
            Controls.Add(label1);
            Controls.Add(label9);
            Name = "Home";
            Size = new Size(705, 650);
            Leave += Home_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private PictureBox pictureBox7;
        private Label label9;
    }
}
