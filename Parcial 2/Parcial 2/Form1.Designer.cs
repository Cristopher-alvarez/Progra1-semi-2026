namespace Parcial_2
{
    partial class frm_usuario
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
            grbEdicion = new GroupBox();
            btnEliminarUsuario = new Button();
            btnModificarUsuario = new Button();
            btnAgregarUsuario = new Button();
            grbNavegacion = new GroupBox();
            btnUltimoUsuario = new Button();
            btnSiguienteUsuario = new Button();
            btnAnteriorUsuario = new Button();
            btnPrimerUsuario = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            grbDatos = new GroupBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtClave = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtConfirmarClave = new TextBox();
            lblNombreUsuario = new Label();
            txtUsuario = new TextBox();
            lblDireccion = new Label();
            lblConfirmarClave = new Label();
            lblClave = new Label();
            lblUsuario = new Label();
            grbEdicion.SuspendLayout();
            grbNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grbEdicion
            // 
            grbEdicion.Controls.Add(btnEliminarUsuario);
            grbEdicion.Controls.Add(btnModificarUsuario);
            grbEdicion.Controls.Add(btnAgregarUsuario);
            grbEdicion.Location = new Point(658, 334);
            grbEdicion.Name = "grbEdicion";
            grbEdicion.Size = new Size(279, 81);
            grbEdicion.TabIndex = 0;
            grbEdicion.TabStop = false;
            grbEdicion.Text = "Edicion";
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarUsuario.Location = new Point(188, 32);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(85, 43);
            btnEliminarUsuario.TabIndex = 7;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificarUsuario.Location = new Point(97, 32);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(85, 43);
            btnModificarUsuario.TabIndex = 6;
            btnModificarUsuario.Text = "Modificar";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarUsuario.Location = new Point(6, 32);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(85, 43);
            btnAgregarUsuario.TabIndex = 5;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregar_Click;
            // 
            // grbNavegacion
            // 
            grbNavegacion.Controls.Add(btnUltimoUsuario);
            grbNavegacion.Controls.Add(btnSiguienteUsuario);
            grbNavegacion.Controls.Add(btnAnteriorUsuario);
            grbNavegacion.Controls.Add(btnPrimerUsuario);
            grbNavegacion.Location = new Point(375, 334);
            grbNavegacion.Name = "grbNavegacion";
            grbNavegacion.Size = new Size(277, 81);
            grbNavegacion.TabIndex = 1;
            grbNavegacion.TabStop = false;
            grbNavegacion.Text = "Navegacion";
            // 
            // btnUltimoUsuario
            // 
            btnUltimoUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUltimoUsuario.Location = new Point(212, 33);
            btnUltimoUsuario.Name = "btnUltimoUsuario";
            btnUltimoUsuario.Size = new Size(59, 43);
            btnUltimoUsuario.TabIndex = 5;
            btnUltimoUsuario.Text = ">|";
            btnUltimoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteUsuario
            // 
            btnSiguienteUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguienteUsuario.Location = new Point(147, 33);
            btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            btnSiguienteUsuario.Size = new Size(59, 43);
            btnSiguienteUsuario.TabIndex = 4;
            btnSiguienteUsuario.Text = ">";
            btnSiguienteUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorUsuario
            // 
            btnAnteriorUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAnteriorUsuario.Location = new Point(65, 33);
            btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            btnAnteriorUsuario.Size = new Size(59, 43);
            btnAnteriorUsuario.TabIndex = 3;
            btnAnteriorUsuario.Text = "<";
            btnAnteriorUsuario.UseVisualStyleBackColor = true;
            // 
            // btnPrimerUsuario
            // 
            btnPrimerUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrimerUsuario.Location = new Point(0, 33);
            btnPrimerUsuario.Name = "btnPrimerUsuario";
            btnPrimerUsuario.Size = new Size(59, 43);
            btnPrimerUsuario.TabIndex = 2;
            btnPrimerUsuario.Text = "|<";
            btnPrimerUsuario.UseVisualStyleBackColor = true;
            //btnPrimerUsuario.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(395, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 197);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Usuario";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Direccion";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.Name = "Column5";
            // 
            // grbDatos
            // 
            grbDatos.Controls.Add(txtTelefono);
            grbDatos.Controls.Add(lblTelefono);
            grbDatos.Controls.Add(txtClave);
            grbDatos.Controls.Add(txtDireccion);
            grbDatos.Controls.Add(txtNombre);
            grbDatos.Controls.Add(txtConfirmarClave);
            grbDatos.Controls.Add(lblNombreUsuario);
            grbDatos.Controls.Add(txtUsuario);
            grbDatos.Controls.Add(lblDireccion);
            grbDatos.Controls.Add(lblConfirmarClave);
            grbDatos.Controls.Add(lblClave);
            grbDatos.Controls.Add(lblUsuario);
            grbDatos.Location = new Point(42, 36);
            grbDatos.Name = "grbDatos";
            grbDatos.Size = new Size(327, 379);
            grbDatos.TabIndex = 3;
            grbDatos.TabStop = false;
            grbDatos.Text = "Datos";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(134, 290);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(187, 23);
            txtTelefono.TabIndex = 12;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(21, 298);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Telefono";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(134, 90);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(187, 23);
            txtClave.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(134, 243);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(187, 23);
            txtDireccion.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 186);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(134, 140);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.Size = new Size(187, 23);
            txtConfirmarClave.TabIndex = 7;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(21, 194);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(51, 15);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "Nombre";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(134, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(187, 23);
            txtUsuario.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(21, 243);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Direccion";
            // 
            // lblConfirmarClave
            // 
            lblConfirmarClave.AutoSize = true;
            lblConfirmarClave.Location = new Point(21, 148);
            lblConfirmarClave.Name = "lblConfirmarClave";
            lblConfirmarClave.Size = new Size(93, 15);
            lblConfirmarClave.TabIndex = 4;
            lblConfirmarClave.Text = "Confirmar Clave";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(21, 98);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 3;
            lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(21, 44);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // frm_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 450);
            Controls.Add(grbDatos);
            Controls.Add(dataGridView1);
            Controls.Add(grbNavegacion);
            Controls.Add(grbEdicion);
            Name = "frm_usuario";
            Text = "Usuario";
            Load += frm_usuario_Load;
            grbEdicion.ResumeLayout(false);
            grbNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbDatos.ResumeLayout(false);
            grbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbEdicion;
        private GroupBox grbNavegacion;
        private Button btnUltimoUsuario;
        private Button btnSiguienteUsuario;
        private Button btnAnteriorUsuario;
        private Button btnPrimerUsuario;
        private Button btnAgregarUsuario;
        private DataGridView dataGridView1;
        private Button btnModificarUsuario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox grbDatos;
        private TextBox txtClave;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtConfirmarClave;
        private TextBox txtUsuario;
        private Label label6;
        private Label label5;
        private Label lblClave;
        private Label lblNombreUsuario;
        private Label lblUsuario;
        private Button btnEliminarUsuario;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblConfirmarClave;
    }
}
