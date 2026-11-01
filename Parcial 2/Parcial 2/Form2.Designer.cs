namespace Parcial_2
{
    partial class frm_Login
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
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuarioLogin = new TextBox();
            txtClaveLogin = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(46, 87);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(46, 156);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(67, 15);
            lblClave.TabIndex = 1;
            lblClave.Text = "Contraseña";
            lblClave.Click += lblClave_Click;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(119, 84);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(100, 23);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // txtClaveLogin
            // 
            txtClaveLogin.Location = new Point(119, 153);
            txtClaveLogin.Name = "txtClaveLogin";
            txtClaveLogin.PasswordChar = '*';
            txtClaveLogin.Size = new Size(100, 23);
            txtClaveLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(119, 238);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Acceder";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 311);
            Controls.Add(btnLogin);
            Controls.Add(txtClaveLogin);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Name = "frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuarioLogin;
        private TextBox txtClaveLogin;
        private Button btnLogin;
    }
}