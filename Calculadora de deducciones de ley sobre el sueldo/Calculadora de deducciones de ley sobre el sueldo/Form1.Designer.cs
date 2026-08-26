
namespace Calculadora_de_deducciones_de_ley_sobre_el_sueldo
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button3 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(359, 364);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(85, 34);
            this.Button3.TabIndex = 26;
            this.Button3.Text = "Salir";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DataGridView1.Location = new System.Drawing.Point(40, 198);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(721, 149);
            this.DataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Empleado";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sueldo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Renta";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ISSS 3%";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "AFP 7.25%";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Deducciones";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pago";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(148, 152);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(62, 20);
            this.TextBox2.TabIndex = 24;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(209, 111);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 23;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(504, 103);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(85, 34);
            this.Button2.TabIndex = 22;
            this.Button2.Text = "Agregar otro";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(404, 103);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(85, 34);
            this.Button1.TabIndex = 21;
            this.Button1.Text = "Calcular";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(92, 156);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Sueldo: $";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(92, 115);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(113, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Nombre del empleado:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(299, 53);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(221, 25);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Pagos a Empleados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

