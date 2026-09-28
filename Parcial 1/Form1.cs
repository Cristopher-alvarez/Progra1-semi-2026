using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Impuesto_Actividades_Economicas
{
    public partial class Parcial_1 : Form
    {
        // Se utiliza decimal para precisión financiera
        private class TramoIAE
        {
            public decimal Desde { get; set; }
            public decimal Hasta { get; set; }
            public decimal ImpuestoFijo { get; set; }
            public decimal FactorPorMillar { get; set; }
        }

        private List<TramoIAE> tablaComercial;

        public Parcial_1()
        {
            InitializeComponent();
        }

        private void Parcial_1_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarTablaIAE();
        }

        private void CargarTablaIAE()
        {
            // Tramos continuos para evitar huecos entre centavos
            tablaComercial = new List<TramoIAE>
            {
                new TramoIAE { Desde = 0m,          Hasta = 1000.00m,      ImpuestoFijo = 6.86m,    FactorPorMillar = 0.000000m },
                new TramoIAE { Desde = 1000.00m,    Hasta = 2857.14m,      ImpuestoFijo = 3.00m,    FactorPorMillar = 3.000000m },
                new TramoIAE { Desde = 2857.14m,    Hasta = 5714.29m,      ImpuestoFijo = 27.43m,   FactorPorMillar = 1.234286m },
                new TramoIAE { Desde = 5714.29m,    Hasta = 22857.14m,     ImpuestoFijo = 58.29m,   FactorPorMillar = 1.097143m },
                new TramoIAE { Desde = 22857.14m,   Hasta = 57142.86m,     ImpuestoFijo = 222.86m,  FactorPorMillar = 0.960000m },
                new TramoIAE { Desde = 57142.86m,   Hasta = 91428.57m,     ImpuestoFijo = 510.86m,  FactorPorMillar = 0.822857m },
                new TramoIAE { Desde = 91428.57m,   Hasta = 137142.86m,    ImpuestoFijo = 757.71m,  FactorPorMillar = 0.685714m },
                new TramoIAE { Desde = 137142.86m,  Hasta = 182857.14m,    ImpuestoFijo = 1032.00m, FactorPorMillar = 0.548571m },
                new TramoIAE { Desde = 182857.14m,  Hasta = 228571.43m,    ImpuestoFijo = 1251.43m, FactorPorMillar = 0.411429m },
                new TramoIAE { Desde = 228571.43m,  Hasta = 342857.14m,    ImpuestoFijo = 1416.00m, FactorPorMillar = 0.274286m },
                new TramoIAE { Desde = 342857.14m,  Hasta = 571428.57m,    ImpuestoFijo = 1690.29m, FactorPorMillar = 0.205714m },
                new TramoIAE { Desde = 571428.57m,  Hasta = 857142.86m,    ImpuestoFijo = 2101.71m, FactorPorMillar = 0.137143m },
                new TramoIAE { Desde = 857142.86m,  Hasta = 1142857.14m,   ImpuestoFijo = 2444.57m, FactorPorMillar = 0.068571m },
                new TramoIAE { Desde = 1142857.14m, Hasta = 1714285.72m,   ImpuestoFijo = 2616.00m, FactorPorMillar = 0.041143m },
                new TramoIAE { Desde = 1714285.72m, Hasta = decimal.MaxValue, ImpuestoFijo = 2821.71m, FactorPorMillar = 0.027429m },
            };
        }

        private void ConfigurarTabla()
        {
            dgvResultados.Columns.Clear();
            dgvResultados.Columns.Add("colNombre", "Nombre / Negocio");
            dgvResultados.Columns.Add("colActivo", "Activo Imponible ($)");
            dgvResultados.Columns.Add("colTramo", "Tramo Aplicado");
            dgvResultados.Columns.Add("colImpuesto", "Impuesto a Pagar ($)");
            dgvResultados.ReadOnly = true;
            dgvResultados.AllowUserToAddRows = false;
        }

        private decimal CalcularImpuesto(decimal activoImponible, out string tramoTexto)
        {
            foreach (TramoIAE tramo in tablaComercial)
            {
                // Evaluamos los rangos asegurando cobertura total
                if (activoImponible >= tramo.Desde && (activoImponible < tramo.Hasta || tramo.Hasta == decimal.MaxValue))
                {
                    decimal excedente = activoImponible - tramo.Desde;
                    decimal fraccionMillar = excedente / 1000.0m;
                    decimal impuestoVariable = fraccionMillar * tramo.FactorPorMillar;
                    decimal impuestoTotal = tramo.ImpuestoFijo + impuestoVariable;

                    string hastaTexto = tramo.Hasta == decimal.MaxValue ? "en adelante" : tramo.Hasta.ToString("N2");
                    tramoTexto = $"${tramo.Desde:N2} - ${hastaTexto}";

                    return Math.Round(impuestoTotal, 2); // Redondeo monetario a 2 decimales
                }
            }

            tramoTexto = "No aplica";
            return 0m;
        }

        private void btnCalcularImpuesto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreNegocio.Text))
            {
                MessageBox.Show("Ingrese el nombre del negocio o contribuyente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Normalización de coma a punto para compatibilidad de teclado
            string textoInput = txtCapitalDeclarado.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(textoInput, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal activoImponible) || activoImponible < 0)
            {
                MessageBox.Show("Ingrese un valor de activo imponible válido y mayor o igual a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Redondeo preventivo a 2 decimales del activo ingresado
            activoImponible = Math.Round(activoImponible, 2);

            decimal impuesto = CalcularImpuesto(activoImponible, out string tramo);

            txtTramoAplicado.Text = tramo;
            txtImpuestoAPagar.Text = impuesto.ToString("C2"); // Formato moneda con símbolo $

            dgvResultados.Rows.Add(
                txtNombreNegocio.Text,
                activoImponible.ToString("N2"),
                tramo,
                impuesto.ToString("N2")
            );
        }

        private void btnLimpiarImpuesto_Click(object sender, EventArgs e)
        {
            txtNombreNegocio.Clear();
            txtCapitalDeclarado.Clear();
            txtTramoAplicado.Clear();
            txtImpuestoAPagar.Clear();
            dgvResultados.Rows.Clear();
            txtNombreNegocio.Focus();
        }
    }
}