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
                nuevoArt.Precio = decimal.Parse(txtbPrecio.Text);
                nuevoArt.marca = (Marca)cboMarca.SelectedItem;
                nuevoArt.Categoria =(Categoria)cboCategoria.SelectedItem;

                negocio.AgregarArticulo(nuevoArt);
                MessageBox.Show("Se agrego correctamente ");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
