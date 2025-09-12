using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion  { get; set; }
        //public Marca marca { get; set; }
        //public Categoria categoria { get; set; }
        //public Imagenes imagenes { get; set; }
        public int Precio { get; set; }





    }
}
