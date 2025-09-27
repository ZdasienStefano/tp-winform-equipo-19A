using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace TP2_19A
{
    internal class inputHelper
    {
        ///Validaciones!!

    

        public static bool estaVacio(TextBox txtBox, string MensajeError= "Campo obligatorio")
        {
            if(string.IsNullOrWhiteSpace(txtBox.Text))
            {
                MarcarError(txtBox, MensajeError);
                return true;
            }
            LimpiarError(txtBox);
            return false;

        }

        /// long minima
        public static bool LongitudMinima(TextBox txtBox, int minLength, string mensajeError = null)
        {
            if (txtBox.Text.Length < minLength)
            {
                MarcarError(txtBox, mensajeError ?? $"Debe tener al menos {minLength} caracteres.");
                return true;
            }

            LimpiarError(txtBox);
            return false;
        }

        /// long maxima
        public static bool LongitudMaxima(TextBox txtBox, int maxLength, string mensajeError = null)
        {
            if (txtBox.Text.Length > maxLength)
            {
                MarcarError(txtBox, mensajeError ?? $"No puede superar los {maxLength} caracteres.");
                return true;
            }

            LimpiarError(txtBox);
            return false;
        }

        // Validacion combinada
        public static bool Validar(TextBox txtBox, int minLength = 0, int maxLength = int.MaxValue, bool soloNumeros = false)
        {
            if (estaVacio(txtBox)) return false;
            if (minLength > 0 && LongitudMinima(txtBox, minLength)) return false;
            if (maxLength < int.MaxValue && LongitudMaxima(txtBox, maxLength)) return false;
            if (soloNumeros && !SoloNumeros(txtBox)) return false;

            LimpiarError(txtBox);
            return true;
        }

        // Valida si contiene solo números
        public static bool SoloNumeros(TextBox txtBox, string mensajeError = "Ingrese solo números")
        {
            if (!Regex.IsMatch(txtBox.Text, @"^\d+$"))
            {
                MarcarError(txtBox, mensajeError);
                return false;
            }

            LimpiarError(txtBox);
            return true;
        }

        /// limpia error visual al escribir
        public static void QuitarErrorAlEscribir(TextBox txtBox)
        {
            txtBox.TextChanged += (s, e) => LimpiarError(txtBox);
        }

        // Limpia filtros (para ComboBox y TextBox)
        public static void LimpiarFiltros(ComboBox cboCampo, ComboBox cboCriterio, TextBox txtFiltro, EventHandler eventoCambio = null)
        {
            if (eventoCambio != null)
                cboCampo.SelectedIndexChanged -= eventoCambio;

            cboCampo.SelectedIndex = -1;
            cboCriterio.Items.Clear();
            cboCriterio.SelectedIndex = -1;
            txtFiltro.Text = string.Empty;

            if (eventoCambio != null)
                cboCampo.SelectedIndexChanged += eventoCambio;

            cboCampo.Refresh();
            cboCriterio.Refresh();
        }

        // Valida URL de imagen (simplificado)
        public static bool ValidarUrlImagen(TextBox txtBox, int minLength = 5, int maxLength = 1000)
        {
            if (estaVacio(txtBox, "El campo URL está vacío")) return false;
            if (LongitudMaxima(txtBox, maxLength) || LongitudMinima(txtBox, minLength)) return false;

            LimpiarError(txtBox);
            return true;
        }

        public static void FormatearPrecio(TextBox txt)
        {
            QuitarErrorAlEscribir(txt);
            string texto = txt.Text;

            string soloNumeros = new string(texto.Where(c => char.IsDigit(c)).ToArray());

            if (string.IsNullOrEmpty(soloNumeros))
            {
                txt.Text = "";
                return;
            }

            if (decimal.TryParse(soloNumeros, out decimal valor))
            {
                valor /= 100m;
                txt.Text = valor.ToString("N2", new System.Globalization.CultureInfo("es-AR"));
                txt.SelectionStart = txt.Text.Length;
            }
        }


        private static void LimpiarError(TextBox txtBox)
        {
            txtBox.BackColor = SystemColors.Window;
        }

        private static void MarcarError(TextBox txtBox, string mensaje)
        {
            txtBox.BackColor = Color.MistyRose;
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtBox.Focus();
        }



    }
}
