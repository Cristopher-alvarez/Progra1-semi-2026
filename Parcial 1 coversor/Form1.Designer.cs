namespace Parcial_1_conversor
{
    partial class Parcial_1_Conversor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblUnidadOrigen = new System.Windows.Forms.Label();
            this.cmbUnidadOrigen = new System.Windows.Forms.ComboBox();
            this.btnIntercambiar = new System.Windows.Forms.Button();
            this.lblUnidadDestino = new System.Windows.Forms.Label();
            this.cmbUnidadDestino = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitulo.Location = new System.Drawing.Point(17, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de Área (Superficie)";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValor.Location = new System.Drawing.Point(17, 52);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(107, 17);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor a convertir:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValor.Location = new System.Drawing.Point(20, 69);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(369, 25);
            this.txtValor.TabIndex = 2;
            // 
            // lblUnidadOrigen
            // 
            this.lblUnidadOrigen.AutoSize = true;
            this.lblUnidadOrigen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUnidadOrigen.Location = new System.Drawing.Point(17, 104);
            this.lblUnidadOrigen.Name = "lblUnidadOrigen";
            this.lblUnidadOrigen.Size = new System.Drawing.Size(114, 17);
            this.lblUnidadOrigen.TabIndex = 3;
            this.lblUnidadOrigen.Text = "Unidad de origen:";
            // 
            // cmbUnidadOrigen
            // 
            this.cmbUnidadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadOrigen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUnidadOrigen.FormattingEnabled = true;
            this.cmbUnidadOrigen.Location = new System.Drawing.Point(20, 121);
            this.cmbUnidadOrigen.Name = "cmbUnidadOrigen";
            this.cmbUnidadOrigen.Size = new System.Drawing.Size(163, 25);
            this.cmbUnidadOrigen.TabIndex = 4;
            // 
            // btnIntercambiar
            // 
            this.btnIntercambiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIntercambiar.Location = new System.Drawing.Point(191, 120);
            this.btnIntercambiar.Name = "btnIntercambiar";
            this.btnIntercambiar.Size = new System.Drawing.Size(34, 26);
            this.btnIntercambiar.TabIndex = 5;
            this.btnIntercambiar.Text = "⇄";
            this.btnIntercambiar.UseVisualStyleBackColor = true;
            this.btnIntercambiar.Click += new System.EventHandler(this.btnIntercambiar_Click);
            // 
            // lblUnidadDestino
            // 
            this.lblUnidadDestino.AutoSize = true;
            this.lblUnidadDestino.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblUnidadDestino.Location = new System.Drawing.Point(234, 104);
            this.lblUnidadDestino.Name = "lblUnidadDestino";
            this.lblUnidadDestino.Size = new System.Drawing.Size(119, 17);
            this.lblUnidadDestino.TabIndex = 6;
            this.lblUnidadDestino.Text = "Unidad de destino:";
            // 
            // cmbUnidadDestino
            // 
            this.cmbUnidadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadDestino.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUnidadDestino.FormattingEnabled = true;
            this.cmbUnidadDestino.Location = new System.Drawing.Point(237, 121);
            this.cmbUnidadDestino.Name = "cmbUnidadDestino";
            this.cmbUnidadDestino.Size = new System.Drawing.Size(152, 25);
            this.cmbUnidadDestino.TabIndex = 7;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.White;
            this.btnConvertir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.Black;
            this.btnConvertir.Location = new System.Drawing.Point(20, 389);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(171, 30);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(218, 389);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(171, 30);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(18, 173);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 16);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtResultado.Location = new System.Drawing.Point(20, 192);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(369, 29);
            this.txtResultado.TabIndex = 11;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(20, 227);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 25;
            this.dgvHistorial.Size = new System.Drawing.Size(369, 156);
            this.dgvHistorial.TabIndex = 12;
            // 
            // Parcial_1_Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 438);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbUnidadDestino);
            this.Controls.Add(this.lblUnidadDestino);
            this.Controls.Add(this.btnIntercambiar);
            this.Controls.Add(this.cmbUnidadOrigen);
            this.Controls.Add(this.lblUnidadOrigen);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Parcial_1_Conversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Área - Parcial 1";
            this.Load += new System.EventHandler(this.Parcial_1_Conversor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblUnidadOrigen;
        private System.Windows.Forms.ComboBox cmbUnidadOrigen;
        private System.Windows.Forms.Button btnIntercambiar;
        private System.Windows.Forms.Label lblUnidadDestino;
        private System.Windows.Forms.ComboBox cmbUnidadDestino;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}
