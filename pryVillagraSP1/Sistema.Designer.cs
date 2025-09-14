namespace pryVillagraSP1
{
    partial class Sistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenido = new Label();
            lblSintepart = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(185, 19);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(150, 32);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido!";
            // 
            // lblSintepart
            // 
            lblSintepart.AutoSize = true;
            lblSintepart.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSintepart.ForeColor = Color.Red;
            lblSintepart.Location = new Point(143, 74);
            lblSintepart.Name = "lblSintepart";
            lblSintepart.Size = new Size(247, 50);
            lblSintepart.TabIndex = 1;
            lblSintepart.Text = "Sintepart SRL";
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 288);
            Controls.Add(lblSintepart);
            Controls.Add(lblBienvenido);
            Name = "Sistema";
            Text = "SintepartSRL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblSintepart;
    }
}