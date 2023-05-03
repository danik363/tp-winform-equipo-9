using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
            string consulta = "Select A.Codigo as Codigo, A.Nombre as Nombre, A.Descripcion as Descripcion, I.ImagenUrl as ImagenUrl, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio as Precio From ARTICULOS A Inner Join IMAGENES I ON A.Id = I.IdArticulo Inner Join MARCAS M ON A.IdMarca = M.Id Inner Join CATEGORIAS C ON A.IdCategoria = C.Id";
            AccesoDatos datos = new AccesoDatos();
            try
			{
				

				datos.setearConsulta(consulta);
				datos.ejecutarConsulta();

				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();

					aux.Codigo = (string)datos.Lector["Codigo"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					aux.urlImagen = (string)datos.Lector["ImagenUrl"];
					aux.Marca = new Marca();
					aux.Marca.Descripcion = (string)datos.Lector["Marca"];
					aux.Categoria = new Categoria();
					aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
					aux.Precio = (decimal)datos.Lector["Precio"];

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
    }
}
