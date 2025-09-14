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

namespace TP2_19A
{
    public partial class Form1 : Form
    {
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
            articuloNegocio negocioArticulo = new articuloNegocio();
            //MarcaNegocio negocioMarca = new MarcaNegocio();
            //CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            dgvArticulos.DataSource = negocioArticulo.listar();
            dgvArticulos.Columns["Imagenes"].Visible = false;
            
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
