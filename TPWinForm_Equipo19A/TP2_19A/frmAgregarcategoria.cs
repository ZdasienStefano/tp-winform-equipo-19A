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
using System.Xml.Schema;

namespace TP2_19A
{
    public partial class frmAgregarcategoria : Form
    {
        private Categoria categoria = null;
        public frmAgregarcategoria()
        {
            InitializeComponent();
            Text = "Nueva Categoria";
        }


        public frmAgregarcategoria(Categoria cat)
        {
            InitializeComponent();
            categoria = cat;
            Text = "Modificar Categoria";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool error = false;
            CategoriaNegocio negocio = new CategoriaNegocio();

            if (!inputHelper.Validar(txtdescripcion, minLength: 4, maxLength: 30))
                error = true;

            if (error) return;

            try
            {
                if (categoria == null)
                    categoria = new Categoria();

                if (categoria.IdCategoria != 0)
                {
                    //categoria.Descripcion = txtdescripcion.Text;
                    negocio.modificar(categoria);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtdescripcion.Text))
                    {
                        MessageBox.Show("El campo descripcion no puede estar vacio");
                        return;
                    }
                    negocio.agregar(categoria);
                    MessageBox.Show("Agregado exitosamente");

                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void frmAgregarcategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    txtdescripcion.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
