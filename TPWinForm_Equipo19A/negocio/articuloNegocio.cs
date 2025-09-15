using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;
using System.Net;

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
                    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];

                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Imagenes = new Imagenes();
                    if (!(datos.Lector["IdArticuloImagen"] is DBNull))
                    aux.Imagenes.IdArticulo = (int)datos.Lector["IdArticuloImagen"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
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
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta(@"INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio); SELECT CAST(SCOPE_IDENTITY() AS int);");

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.marca.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.IdCategoria);
                datos.setearParametro("@Precio", nuevo.Precio);



                int idArticulo = (int)datos.ejecutarScalar();

                datos.setearConsulta(@"INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@ImagenUrl", nuevo.Imagenes.ImagenUrl);
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally { 
                datos.cerrarConexion();
            }

        }

        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @IdCategoria, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idMarca", articulo.marca.IdMarca);
                datos.setearParametro("@IdCategoria", articulo.Categoria.IdCategoria);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.IdArticulo);

                datos.ejecutarAccion();
                
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

        public void eliminar(int id)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("DELETE from ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }






        }


    }
}
