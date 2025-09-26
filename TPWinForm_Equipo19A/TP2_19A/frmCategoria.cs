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


        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            DGVCat.DataSource = negocio.listar();
            

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


       
    }
}
