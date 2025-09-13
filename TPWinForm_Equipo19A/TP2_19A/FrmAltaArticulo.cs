using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_19A
{
    public partial class FrmAltaArticulo : Form
    {
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Articulo nuevoArt = new Articulo();
            articuloNegocio negocio = new articuloNegocio();

            try
            {
                
                nuevoArt.Nombre=txtbNombre.Text;
                nuevoArt.Codigo=txbCodigo.Text;
                nuevoArt.Descripcion=txbDescripcion.Text;

                negocio.AgregarArticulo(nuevoArt);
                MessageBox.Show("Se agrego correctamente ");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
