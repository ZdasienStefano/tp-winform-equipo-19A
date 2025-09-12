using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class articuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB ; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select codigo, Nombre, A.Descripcion ,Precio, M.Id as IdMarca, M.Descripcion as Marca, C.Id as IdCategoria, C.Descripcion as Categoria from Articulos A, Marcas M, Categorias C\r\n";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"]; 
                    aux.Precio = lector.GetSqlMoney(lector.GetOrdinal("Precio")).ToDecimal();
                    aux.marca = new Marca();
                    //aux.marca.IdMarca = lector.GetInt32(lector.GetOrdinal("IdMarca"));
                    aux.marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    //aux.Categoria.IdCategoria = lector.GetInt32(lector.GetOrdinal("IdCategoria"));
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;

            }
            catch (Exception )
            {

                throw;
            }

        }




    }
}
