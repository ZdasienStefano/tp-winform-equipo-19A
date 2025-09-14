using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;

namespace negocio
{
    public class articuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("\r\nSELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Id AS IdMarca, M.Descripcion AS Marca, C.Id AS IdCategoria, C.Descripcion AS Categoria FROM Articulos A LEFT JOIN Marcas M ON A.IdMarca = M.Id LEFT JOIN Categorias C ON A.IdCategoria = C.Id;\r\n");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"]; 
                    aux.Precio = datos.Lector.GetSqlMoney(datos.Lector.GetOrdinal("Precio")).ToDecimal();

                    aux.marca = new Marca();
                    aux.marca.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.marca.Descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    //if (datos.Lector["IdCategoria"] != DBNull.Value)
                    //    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];

                    if (datos.Lector["Categoria"] != DBNull.Value)
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    else
                        aux.Categoria.Descripcion = "(sin categoría)";

                    lista.Add(aux);
                }
                
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }






        }

        public void AgregarArticulo(Articulo nuevo)
        {

            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }


    }
}
