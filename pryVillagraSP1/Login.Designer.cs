namespace pryVillagraSP1
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblMódulo = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cbMódulo = new ComboBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(49, 68);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(57, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblMódulo
            // 
            lblMódulo.AutoSize = true;
            lblMódulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMódulo.Location = new Point(49, 238);
            lblMódulo.Name = "lblMódulo";
            lblMódulo.Size = new Size(55, 17);
            lblMódulo.TabIndex = 1;
            lblMódulo.Text = "Módulo";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(49, 145);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(77, 17);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.Blue;
            txtUsuario.Location = new Point(163, 65);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.Tag = "10";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(163, 145);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(369, 88);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(99, 26);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(369, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 26);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbMódulo
            // 
            cbMódulo.FormattingEnabled = true;
            cbMódulo.Items.AddRange(new object[] { "ADM ", "SIST ", "COM ", "VTA " });
            cbMódulo.Location = new Point(163, 235);
            cbMódulo.Name = "cbMódulo";
            cbMódulo.Size = new Size(121, 23);
            cbMódulo.TabIndex = 7;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 311);
            Controls.Add(cbMódulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblMódulo);
            Controls.Add(lblUsuario);
            Name = "login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblMódulo;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cbMódulo;
    }
}
