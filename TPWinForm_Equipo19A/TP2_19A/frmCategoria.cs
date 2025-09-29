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
    public partial class frmCategoria : Form
    {
        private List<Categoria> ListaCategoria = new List<Categoria>();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                ListaCategoria = negocio.listar();
                DGVCat.DataSource = ListaCategoria;
                DGVCat.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargar();

        }



        private void DGVCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                string filtro = txtFiltro.Text;
                List<Categoria> FiltroLista;

                if (filtro.Length >= 2)
                {
                    FiltroLista = ListaCategoria.FindAll(XmlReadMode => XmlReadMode.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                    
                }
                else { FiltroLista = ListaCategoria; 
                
                    DGVCat.DataSource = null;
                    DGVCat.DataSource = FiltroLista;
                    DGVCat.Columns["IdCategoria"].Visible = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private bool validarSeleccion()
        {
            if (DGVCat.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarcategoria formulario = new frmAgregarcategoria();
            formulario.ShowDialog();
            cargar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarSeleccion()) return;

                Categoria seleccionada = (Categoria)DGVCat.CurrentRow.DataBoundItem;
                frmAgregarcategoria modificar = new frmAgregarcategoria(seleccionada);
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

            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada = (Categoria)DGVCat.CurrentRow.DataBoundItem;

            articuloNegocio negocioArticulo = new articuloNegocio();
            List<Articulo> listaArticulos = negocioArticulo.listar();

            try
            {
                foreach (Articulo item in listaArticulos)
                {
                    if (item.Categoria.IdCategoria == seleccionada.IdCategoria)
                    {
                        MessageBox.Show("La categoría seleccionada no se puede eliminar porque tiene artículos relacionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar definitivamente esta categoría?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(seleccionada.IdCategoria);
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
                List<Categoria> listaFiltrada;

                if (filtro.Length >= 2)
                    listaFiltrada = ListaCategoria.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                else
                    listaFiltrada = ListaCategoria;

                DGVCat.DataSource = null;
                DGVCat.DataSource = listaFiltrada;
                DGVCat.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

}
}
