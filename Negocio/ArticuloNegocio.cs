﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Security.Cryptography.X509Certificates;
using Negocio;

namespace Negocio
{
    public class ArticuloNegocio
    {
		public void agregar(Articulo nuevo)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio); SELECT SCOPE_IDENTITY();");
				datos.setearParametros("@codigo", nuevo.Codigo);
                datos.setearParametros("@nombre", nuevo.Nombre);
                datos.setearParametros("@descripcion", nuevo.Descripcion);
				datos.setearParametros("@idMarca", nuevo.Marca.Id);
                datos.setearParametros("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@precio", nuevo.Precio);

                nuevo.Imagen.IdArticulo = datos.ejecutarReturnQuery(); //Retorna el id del articulo ingresado a la tabla
				
				datos.cerrarConexion();

				datos.setearConsulta("Insert into IMAGENES (IdArticulo, ImagenUrl) values (@articulo, @url)");
                datos.setearParametros("@articulo", nuevo.Imagen.IdArticulo);
                datos.setearParametros("@url", nuevo.Imagen.Url);

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
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
            string consulta = "Select A.Codigo, A.Nombre, A.Descripcion, I.ImagenUrl, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio From ARTICULOS A Inner Join IMAGENES I ON A.Id = I.IdArticulo Inner Join MARCAS M ON A.IdMarca = M.Id Inner Join CATEGORIAS C ON A.IdCategoria = C.Id";
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
					aux.Descripcion = (string)datos.Lector["Descripcion"]; //El modelo que se esta creando no necesita una validacion de null al momento de traer los datos de la db
					aux.Imagen = new Imagen();
					if(!(datos.Lector["ImagenUrl"] is DBNull)){
                        aux.Imagen.Url = (string)datos.Lector["ImagenUrl"];//Debido a que desde el lado de la app se obliga a colocar todos los datos 
					}
					else
					{
						aux.Imagen.Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png";

                    }
					
					
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
