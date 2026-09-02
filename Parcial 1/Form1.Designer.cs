namespace Impuesto_Actividades_Economicas
{
    partial class Parcial_1
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreNegocio = new System.Windows.Forms.Label();
            this.txtNombreNegocio = new System.Windows.Forms.TextBox();
            this.lblCapitalDeclarado = new System.Windows.Forms.Label();
            this.txtCapitalDeclarado = new System.Windows.Forms.TextBox();
            this.lblTramoAplicado = new System.Windows.Forms.Label();
            this.txtTramoAplicado = new System.Windows.Forms.TextBox();
            this.lblImpuestoAPagar = new System.Windows.Forms.Label();
            this.txtImpuestoAPagar = new System.Windows.Forms.TextBox();
            this.btnCalcularImpuesto = new System.Windows.Forms.Button();
            this.btnLimpiarImpuesto = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(22, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(346, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Impuesto a las Actividades Económicas";
            // 
            // lblNombreNegocio
            // 
            this.lblNombreNegocio.AutoSize = true;
            this.lblNombreNegocio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNegocio.Location = new System.Drawing.Point(22, 65);
            this.lblNombreNegocio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreNegocio.Name = "lblNombreNegocio";
            this.lblNombreNegocio.Size = new System.Drawing.Size(142, 17);
            this.lblNombreNegocio.TabIndex = 1;
            this.lblNombreNegocio.Text = "Nombre del negocio:";
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNombreNegocio.Location = new System.Drawing.Point(194, 59);
            this.txtNombreNegocio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.Size = new System.Drawing.Size(196, 27);
            this.txtNombreNegocio.TabIndex = 2;
            this.txtNombreNegocio.TextChanged += new System.EventHandler(this.txtNombreNegocio_TextChanged);
            // 
            // lblCapitalDeclarado
            // 
            this.lblCapitalDeclarado.AutoSize = true;
            this.lblCapitalDeclarado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalDeclarado.Location = new System.Drawing.Point(22, 98);
            this.lblCapitalDeclarado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapitalDeclarado.Name = "lblCapitalDeclarado";
            this.lblCapitalDeclarado.Size = new System.Drawing.Size(195, 17);
            this.lblCapitalDeclarado.TabIndex = 3;
            this.lblCapitalDeclarado.Text = "Activo / capital declarado ($):";
            // 
            // txtCapitalDeclarado
            // 
            this.txtCapitalDeclarado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCapitalDeclarado.Location = new System.Drawing.Point(221, 92);
            this.txtCapitalDeclarado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCapitalDeclarado.Name = "txtCapitalDeclarado";
            this.txtCapitalDeclarado.Size = new System.Drawing.Size(196, 27);
            this.txtCapitalDeclarado.TabIndex = 4;
            // 
            // lblTramoAplicado
            // 
            this.lblTramoAplicado.AutoSize = true;
            this.lblTramoAplicado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramoAplicado.Location = new System.Drawing.Point(22, 130);
            this.lblTramoAplicado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramoAplicado.Name = "lblTramoAplicado";
            this.lblTramoAplicado.Size = new System.Drawing.Size(112, 17);
            this.lblTramoAplicado.TabIndex = 5;
            this.lblTramoAplicado.Text = "Tramo aplicado:";
            // 
            // txtTramoAplicado
            // 
            this.txtTramoAplicado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTramoAplicado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTramoAplicado.Location = new System.Drawing.Point(202, 128);
            this.txtTramoAplicado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTramoAplicado.Name = "txtTramoAplicado";
            this.txtTramoAplicado.ReadOnly = true;
            this.txtTramoAplicado.Size = new System.Drawing.Size(196, 27);
            this.txtTramoAplicado.TabIndex = 6;
            // 
            // lblImpuestoAPagar
            // 
            this.lblImpuestoAPagar.AutoSize = true;
            this.lblImpuestoAPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestoAPagar.ForeColor = System.Drawing.Color.Black;
            this.lblImpuestoAPagar.Location = new System.Drawing.Point(22, 162);
            this.lblImpuestoAPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpuestoAPagar.Name = "lblImpuestoAPagar";
            this.lblImpuestoAPagar.Size = new System.Drawing.Size(156, 18);
            this.lblImpuestoAPagar.TabIndex = 7;
            this.lblImpuestoAPagar.Text = "Impuesto a pagar ($):";
            // 
            // txtImpuestoAPagar
            // 
            this.txtImpuestoAPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtImpuestoAPagar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtImpuestoAPagar.ForeColor = System.Drawing.Color.Black;
            this.txtImpuestoAPagar.Location = new System.Drawing.Point(202, 160);
            this.txtImpuestoAPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImpuestoAPagar.Name = "txtImpuestoAPagar";
            this.txtImpuestoAPagar.ReadOnly = true;
            this.txtImpuestoAPagar.Size = new System.Drawing.Size(196, 27);
            this.txtImpuestoAPagar.TabIndex = 8;
            // 
            // btnCalcularImpuesto
            // 
            this.btnCalcularImpuesto.BackColor = System.Drawing.Color.White;
            this.btnCalcularImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularImpuesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImpuesto.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularImpuesto.Location = new System.Drawing.Point(138, 377);
            this.btnCalcularImpuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcularImpuesto.Name = "btnCalcularImpuesto";
            this.btnCalcularImpuesto.Size = new System.Drawing.Size(90, 34);
            this.btnCalcularImpuesto.TabIndex = 9;
            this.btnCalcularImpuesto.Text = "Calcular";
            this.btnCalcularImpuesto.UseVisualStyleBackColor = false;
            this.btnCalcularImpuesto.Click += new System.EventHandler(this.btnCalcularImpuesto_Click);
            // 
            // btnLimpiarImpuesto
            // 
            this.btnLimpiarImpuesto.BackColor = System.Drawing.Color.White;
            this.btnLimpiarImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarImpuesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarImpuesto.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarImpuesto.Location = new System.Drawing.Point(300, 377);
            this.btnLimpiarImpuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarImpuesto.Name = "btnLimpiarImpuesto";
            this.btnLimpiarImpuesto.Size = new System.Drawing.Size(90, 34);
            this.btnLimpiarImpuesto.TabIndex = 10;
            this.btnLimpiarImpuesto.Text = "Limpiar";
            this.btnLimpiarImpuesto.UseVisualStyleBackColor = false;
            this.btnLimpiarImpuesto.Click += new System.EventHandler(this.btnLimpiarImpuesto_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResultados.ColumnHeadersHeight = 29;
            this.dgvResultados.Location = new System.Drawing.Point(25, 191);
            this.dgvResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.Size = new System.Drawing.Size(465, 162);
            this.dgvResultados.TabIndex = 11;
            // 
            // Parcial_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(518, 447);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnLimpiarImpuesto);
            this.Controls.Add(this.btnCalcularImpuesto);
            this.Controls.Add(this.txtImpuestoAPagar);
            this.Controls.Add(this.lblImpuestoAPagar);
            this.Controls.Add(this.txtTramoAplicado);
            this.Controls.Add(this.lblTramoAplicado);
            this.Controls.Add(this.txtCapitalDeclarado);
            this.Controls.Add(this.lblCapitalDeclarado);
            this.Controls.Add(this.txtNombreNegocio);
            this.Controls.Add(this.lblNombreNegocio);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Parcial_1";
            this.Text = "Impuesto a las Actividades Económicas";
            this.Load += new System.EventHandler(this.Parcial_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreNegocio;
        private System.Windows.Forms.TextBox txtNombreNegocio;
        private System.Windows.Forms.Label lblCapitalDeclarado;
        private System.Windows.Forms.TextBox txtCapitalDeclarado;
        private System.Windows.Forms.Label lblTramoAplicado;
        private System.Windows.Forms.TextBox txtTramoAplicado;
        private System.Windows.Forms.Label lblImpuestoAPagar;
        private System.Windows.Forms.TextBox txtImpuestoAPagar;
        private System.Windows.Forms.Button btnCalcularImpuesto;
        private System.Windows.Forms.Button btnLimpiarImpuesto;
        private System.Windows.Forms.DataGridView dgvResultados;
    }
}