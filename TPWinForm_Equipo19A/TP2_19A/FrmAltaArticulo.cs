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
using dominio;

namespace TP2_19A
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;

        public FrmAltaArticulo()
        {
            InitializeComponent();
        }


        public FrmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            articuloNegocio negocio = new articuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Nombre = txtbNombre.Text;
                articulo.Codigo = txbCodigo.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.Precio = decimal.Parse(txtbPrecio.Text);
                articulo.Imagenes.ImagenUrl = txtUrl.Text;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;


                if (articulo.IdArticulo != 0)
                {
               
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Modificado correctamente ");

                }
                else
                {
                    negocio.AgregarArticulo(articulo);
                    MessageBox.Show("Se agrego correctamente ");
                    Close();
                }


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
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtbNombre.Text = articulo.Nombre;
                    txbCodigo.Text = articulo.Codigo;
                    txbDescripcion.Text = articulo.Descripcion;
                    txtbPrecio.Text = articulo.Precio.ToString();
                    txtUrl.Text = articulo.Imagenes.ImagenUrl;
                    cargarImagen(articulo.Imagenes.ImagenUrl);
                    cboMarca.SelectedValue = articulo.marca.IdMarca;
                    cboCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text);
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcToma8_PVWQSIC8hkjva3LwejHu4BqZsSjgPg&s");
            }
        }
    }
}
