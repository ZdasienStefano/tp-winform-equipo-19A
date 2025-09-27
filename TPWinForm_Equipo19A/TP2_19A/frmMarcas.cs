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
    public partial class frmMarcas : Form
    {
        private List<Marca> ListaMarcas = new List<Marca>();
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void DGVCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text;
                List<Marca> FiltroLista;

                if (filtro.Length >= 2)
                {
                    FiltroLista = ListaMarcas.FindAll(XmlReadMode => XmlReadMode.Descripcion.ToUpper().Contains(filtro.ToUpper()));

                }
                else
                {
                    FiltroLista = ListaMarcas;

                    DGVCat.DataSource = null;
                    DGVCat.DataSource = FiltroLista;
                    DGVCat.Columns["IdMarca"].Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                ListaMarcas = negocio.listar();
                DGVCat.DataSource = ListaMarcas;
                DGVCat.Columns["IdMarca"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private bool validarSeleccion()
        {
            if (DGVCat.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione una Marca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formulario = new frmAgregarMarcas();
            formulario.ShowDialog();
            cargar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarSeleccion()) return;

                Marca seleccion = (Marca)DGVCat.CurrentRow.DataBoundItem;
                frmAgregarMarcas modificar = new frmAgregarMarcas(seleccion);
                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (validarSeleccion()) return;

            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccion = (Marca)DGVCat.CurrentRow.DataBoundItem;

            articuloNegocio negocioArticulo = new articuloNegocio();
            List<Articulo> listaArticulos = negocioArticulo.listar();

            try
            {
                foreach (Articulo item in listaArticulos)
                {
                    if (item.marca.IdMarca == seleccion.IdMarca)
                    {
                        MessageBox.Show("La Marca seleccionada no se puede eliminar porque tiene artículos relacionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar definitivamente esta Marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccion.IdMarca);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                List<Marca> listaFiltrada;

                if (filtro.Length >= 2)
                    listaFiltrada = ListaMarcas.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                else
                    listaFiltrada = ListaMarcas;

                DGVCat.DataSource = null;
                DGVCat.DataSource = listaFiltrada;
                DGVCat.Columns["IdMarca"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}
