using System;
using System.Globalization;
using System.Windows.Forms;

namespace Alquiler_de_vehiculos
{
    public partial class Form1 : Form
    {
        // Constantes de negocio (RD$)
        private const decimal RECARGO_SEGURO_COMPLETO = 300m;
        private const decimal RECARGO_GPS_DIA = 100m;
        private const decimal PORCENTAJE_DESCUENTO_CORPORATIVO = 0.15m;
        private const decimal COSTO_ENTREGA_DOMICILIO = 500m;
        private const decimal TASA_ITBIS = 0.18m;

        // Anchos de columnas para el formato en ListBox y encabezado (fuente Consola)
        private const int ANCHO_DIAS = 6;
        private const int ANCHO_VEHICULO = 24;
        private const int ANCHO_TARIFA = 10;
        private const int ANCHO_TOTAL = 12;

        // Acumulador del subtotal de líneas agregadas
        private decimal subtotalAcumulado = 0m;

        // Cultura para formato numérico/moneda consistente (ej. 2,500.00)
        private readonly CultureInfo culturaRD = new CultureInfo("en-US");

        public Form1()
        {
            InitializeComponent();
        }

        // Evento Load: valores iniciales y encabezado de columnas
        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarTodo();
        }

        // Botón "Agregar al alquiler"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreVehiculo = txtVehiculo.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreVehiculo))
            {
                MessageBox.Show(
                    "Debe digitar el nombre del vehículo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtVehiculo.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out decimal tarifaDigitada) &&
                !decimal.TryParse(txtTarifa.Text.Trim(), NumberStyles.Any, culturaRD, out tarifaDigitada))
            {
                MessageBox.Show(
                    "Digite una tarifa diaria válida.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtTarifa.Focus();
                return;
            }

            if (tarifaDigitada <= 0)
            {
                MessageBox.Show(
                    "La tarifa diaria debe ser mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtTarifa.Focus();
                return;
            }

            int dias = (int)nudDias.Value;

            // Regla 1: Tarifa diaria = tarifa digitada + 300 si seguro completo + 100 si lleva GPS
            decimal tarifaDiaria = tarifaDigitada;
            bool tieneSeguroCompleto = rbtCompleto.Checked;
            bool tieneGps = chkGps.Checked;

            if (tieneSeguroCompleto)
            {
                tarifaDiaria += RECARGO_SEGURO_COMPLETO;
            }

            if (tieneGps)
            {
                tarifaDiaria += RECARGO_GPS_DIA;
            }

            // Regla 2: Total de línea = tarifa diaria * días; Subtotal = suma de las líneas
            decimal totalLinea = tarifaDiaria * dias;
            subtotalAcumulado += totalLinea;

            string etiquetaExtra = ObtenerEtiquetaVehiculo(nombreVehiculo, tieneSeguroCompleto, tieneGps);
            string lineaFormateada = FormatearFila(
                dias.ToString(),
                etiquetaExtra,
                tarifaDiaria.ToString("N2", culturaRD),
                totalLinea.ToString("N2", culturaRD)
            );

            lstAlquileres.Items.Add(lineaFormateada);
            lblSubtotal.Text = FormatearMoneda(subtotalAcumulado);

            // Reiniciar controles del vehículo para agregar otro si se desea
            LimpiarControlesVehiculo();
        }

        // Botón "Calcular total"
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show(
                    "No hay vehículos agregados al alquiler para calcular el total.",
                    "Sin vehículos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            decimal subtotal = subtotalAcumulado;

            // Regla 3: Descuento 15% del subtotal si el cliente es corporativo
            decimal descuento = chkCorporativo.Checked
                ? subtotal * PORCENTAJE_DESCUENTO_CORPORATIVO
                : 0m;

            // Regla 4: Entrega a domicilio RD$500 una sola vez por alquiler
            decimal domicilio = rbtDomicilio.Checked
                ? COSTO_ENTREGA_DOMICILIO
                : 0m;

            // Regla 5: Base imponible = subtotal - descuento + entrega a domicilio
            decimal baseImponible = subtotal - descuento + domicilio;

            // Regla 6: ITBIS = 18% de la base imponible; Total = base imponible + ITBIS
            decimal itbis = baseImponible * TASA_ITBIS;
            decimal totalPagar = baseImponible + itbis;

            lblSubtotal.Text = FormatearMoneda(subtotal);
            lblDescuento.Text = FormatearMoneda(descuento);
            lblDomicilio.Text = FormatearMoneda(domicilio);
            lblItbis.Text = FormatearMoneda(itbis);
            lblTotal.Text = FormatearMoneda(totalPagar);
        }

        // Botón "Nuevo alquiler"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            InicializarTodo();
            txtCliente.Focus();
        }

        // Botón "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        // --- Métodos auxiliares ---

        private void InicializarTodo()
        {
            subtotalAcumulado = 0m;

            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Today;

            LimpiarControlesVehiculo();

            // Entrega: Sucursal por defecto
            rbtSucursal.Checked = true;
            rbtDomicilio.Checked = false;

            // Encabezado con el mismo formato de columnas (anchos 6, 24, 10 y 12)
            btnAgregar.Text = FormatearFila("Días", "Vehículo", "Tarifa", "Total");
            lstAlquileres.Items.Clear();

            // Reiniciar etiquetas de resultados en formato RD$ 0.00
            lblSubtotal.Text = FormatearMoneda(0m);
            lblDescuento.Text = FormatearMoneda(0m);
            lblDomicilio.Text = FormatearMoneda(0m);
            lblItbis.Text = FormatearMoneda(0m);
            lblTotal.Text = FormatearMoneda(0m);
        }

        private void LimpiarControlesVehiculo()
        {
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;

            // Seguro: Básico por defecto
            rbtBasico.Checked = true;
            rbtCompleto.Checked = false;
            chkGps.Checked = false;

            txtVehiculo.Focus();
        }

        private static string ObtenerEtiquetaVehiculo(string vehiculo, bool seguroCompleto, bool gps)
        {
            if (seguroCompleto && gps)
            {
                return $"{vehiculo} (Completo, GPS)";
            }
            if (seguroCompleto)
            {
                return $"{vehiculo} (Completo)";
            }
            if (gps)
            {
                return $"{vehiculo} (GPS)";
            }
            return vehiculo;
        }

        private static string FormatearFila(string colDias, string colVehiculo, string colTarifa, string colTotal)
        {
            // Si el texto del vehículo supera el ancho permitido, se recorta para mantener alineación
            if (colVehiculo.Length > ANCHO_VEHICULO)
            {
                colVehiculo = colVehiculo.Substring(0, ANCHO_VEHICULO);
            }

            string d = colDias.PadRight(ANCHO_DIAS);
            string v = colVehiculo.PadRight(ANCHO_VEHICULO);
            string tar = colTarifa.PadLeft(ANCHO_TARIFA);
            string tot = colTotal.PadLeft(ANCHO_TOTAL);

            return $"{d}{v}{tar}{tot}";
        }

        private string FormatearMoneda(decimal monto)
        {
            return $"RD$ {monto.ToString("N2", culturaRD)}";
        }

        private void lstAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}