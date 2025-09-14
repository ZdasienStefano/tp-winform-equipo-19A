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
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Id AS IdMarca, M.Descripcion AS Marca, C.Id AS IdCategoria, C.Descripcion AS Categoria, I.IdArticulo AS IdArticuloImagen, I.ImagenUrl FROM Articulos A LEFT JOIN Marcas M ON A.IdMarca = M.Id LEFT JOIN Categorias C ON A.IdCategoria = C.Id LEFT JOIN Imagenes I ON A.Id = I.IdArticulo;");
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
                    //aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];

                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Imagenes = new Imagenes();
                    aux.Imagenes.IdImagen = (int)datos.Lector["IdArticuloImagen"];
                    aux.Imagenes.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                

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
