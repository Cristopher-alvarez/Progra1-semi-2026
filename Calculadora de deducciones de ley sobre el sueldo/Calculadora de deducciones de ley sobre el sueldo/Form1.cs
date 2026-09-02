using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_deducciones_de_ley_sobre_el_sueldo
{
    public partial class frmSueldos : Form
    {
        public frmSueldos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button2.Enabled = false;
            Button1.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox2.Text))
            {
                MessageBox.Show("Por favor, llena el nombre y el sueldo del empleado.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string empleado = TextBox1.Text.Trim();

            if (!double.TryParse(TextBox2.Text.Trim(), out double sueldo))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido para el sueldo.", "Sueldo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double isss = (sueldo > 1000) ? 30.0 : sueldo * 0.03;
            double afp = sueldo * 0.0725;
            double sueldoGravado = sueldo - isss - afp;
            double renta = 0;

            if (sueldoGravado >= 0.01 && sueldoGravado <= 472.0)
            {
                renta = 0.0;
            }
            else if (sueldoGravado >= 472.01 && sueldoGravado <= 895.24)
            {
                renta = ((sueldoGravado - 472.0) * 0.1) + 17.67;
            }
            else if (sueldoGravado >= 895.25 && sueldoGravado <= 2038.1)
            {
                renta = ((sueldoGravado - 895.24) * 0.2) + 60.0;
            }
            else if (sueldoGravado >= 2038.11)
            {
                renta = ((sueldoGravado - 2038.1) * 0.3) + 288.57;
            }

            double deducciones = isss + afp + renta;
            double pagoNeto = sueldo - deducciones;

            DataGridView1.Rows.Add(
                empleado,
                sueldo.ToString("F2"),
                renta.ToString("F2"),
                isss.ToString("F2"),
                afp.ToString("F2"),
                deducciones.ToString("F2"),
                pagoNeto.ToString("F2")
            );

            Button1.Enabled = false;
            Button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();

            Button1.Enabled = true;
            Button2.Enabled = false;

            TextBox1.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esDigito = char.IsDigit(e.KeyChar);
            bool esControl = char.IsControl(e.KeyChar);
            bool esPunto = e.KeyChar == '.';
            bool yaTienePunto = (sender as TextBox).Text.Contains(".");

            if (!esDigito && !esControl && (!esPunto || yaTienePunto))
            {
                e.Handled = true;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}