using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TP2_19A
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulo;

        public Form1()
        {
            InitializeComponent();
        }

  

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();
            cboxCampo.Items.Add("Codigo");
            cboxCampo.Items.Add("Nombre");
            cboxCampo.Items.Add("Descripcion");
            cboxCampo.Items.Add("Marca");
            cboxCampo.Items.Add("Categoria");
            cboxCampo.Items.Add("Precio");



        }

        private void cargar()
        {
            articuloNegocio negocioArticulo = new articuloNegocio();
            try
            {
                listaArticulo = negocioArticulo.listar();

                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["Imagenes"].Visible = false;
                pbxArticulo.Load(listaArticulo[0].Imagenes.ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagenes.ImagenUrl);

            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://imgs.search.brave.com/OVvzmbbxrY7lVcrnLzzP7RlXGAquhblwol46p_tz1tA/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/dmVjdG9yLXByZW1p/dW0vaWx1c3RyYWNp/b24tYXJjaGl2by12/YWNpby1wZXJmZWN0/YS1wcm95ZWN0b3Mt/aW50ZXJmYXotdXN1/YXJpby11aXV4Xzg1/NDA3OC0yMDk2Lmpw/Zw");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            Articulo seleccionado;
            try
            {
               DialogResult respuesta = MessageBox.Show("¿Estas seguro de querer eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdArticulo);
                    MessageBox.Show("Se elimino el articulo correctamente!");
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
            List <Articulo> ListaFiltrada;
            string filtro = txtFiltro.Text;

            if(filtro != "")
            {

                ListaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().Contains(filtro) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                ListaFiltrada = listaArticulo; 
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = ListaFiltrada;
            dgvArticulos.Columns["Imagenes"].Visible = false;

        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Mayor a");
                cboxCriterio.Items.Add("Menor a");
                cboxCriterio.Items.Add("Igual a");
            }


            else
            {
                cboxCriterio.Items.Clear();
                cboxCriterio.Items.Add("Comienza con");
                cboxCriterio.Items.Add("Termina con");
                cboxCriterio.Items.Add("Contiene");
            }

        }


        private bool validarFiltro(){


            if (cboxCampo.SelectedIndex == -1) {

                MessageBox.Show("por favor, seleccione el campo a filtar ");
                return true;
            }
            if (cboxCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("por favor, seleccione el criterio a filtar ");
                return true;
            }
            if (cboxCampo.SelectedItem.ToString() == "Precio")
            {
                if(string.IsNullOrEmpty(txtboxFiltro.Text)){

                    MessageBox.Show("Debes cargar el filtro para numericos");
                    return true;
                }
                if (!(soloNumeros(txtboxFiltro.Text)))
                {
                    MessageBox.Show("ingrese solo numeros por favor");
                    return true;

                }

            }
            
            return false;
        
        }

        private bool soloNumeros( string cadena){


            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter))) { 
                    return false;
                }
            }

            return true;
        }


        private void btnFiltrarAvanzado_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            
            try
            {

                if(validarFiltro())
                    return ;

                string campo = cboxCampo.SelectedItem.ToString();
                string criterio = cboxCriterio.SelectedItem.ToString();
                string filtro = txtboxFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marca = new frmMarcas();
            marca.ShowDialog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
