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
    public partial class frmAgregarMarcas : Form
    {
        private Marca Marcas = null;
        public frmAgregarMarcas()
        {
            InitializeComponent();
            Text = "Nueva Marca";
        }

        public frmAgregarMarcas(Marca Mar)
        {
            InitializeComponent();
            Marcas = Mar;
            Text = "Modificar Marca";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool error = false;
            MarcaNegocio negocio = new MarcaNegocio();

            if (!inputHelper.Validar(txtdescripcion, minLength: 4, maxLength: 30))
                error = true;

            if (error) return;

            try
            {
                if (Marcas == null)
                    Marcas = new Marca();
                Marcas.Descripcion = txtdescripcion.Text.Trim();

                if (negocio.ExisteNombre(Marcas.Descripcion, Marcas.IdMarca))
                {
                    MessageBox.Show("Ya existe una categoría con esa descripción.");
                    return;
                }


                if (Marcas.IdMarca != 0)
                {
                    negocio.modificar(Marcas);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtdescripcion.Text))
                    {
                        MessageBox.Show("El campo Marca no puede estar vacio");
                        return;
                    }
                    negocio.agregar(Marcas);
                    MessageBox.Show("Agregado exitosamente");

                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void frmAgregarMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Marcas != null)
                {
                    txtdescripcion.Text = Marcas.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
