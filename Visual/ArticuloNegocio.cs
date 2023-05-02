﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Visual
{
    internal class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Select A.Codigo as Codigo, A.Nombre as Nombre, A.Descripcion as Descripcion, I.ImagenUrl as ImagenUrl, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio as Precio From ARTICULOS A Inner Join IMAGENES I ON A.Id = I.IdArticulo Inner Join MARCAS M ON A.IdMarca = M.Id Inner Join CATEGORIAS C ON A.IdCategoria = C.Id";
				comando.Connection = conexion;

				conexion.Open();
				lector = comando.ExecuteReader();

				while (lector.Read())
				{
					Articulo aux = new Articulo();

					aux.Codigo = (string)lector["Codigo"];
					aux.Nombre = (string)lector["Nombre"];
					aux.Descripcion = (string)lector["Descripcion"];
					aux.Imagen = new Imagen();
					aux.Imagen.Url = (string)lector["ImagenUrl"];
					aux.Marca = new Marca();
					aux.Marca.Descripcion = (string)lector["Marca"];
					aux.Categoria = new Categoria();
					aux.Categoria.Descripcion = (string)lector["Categoria"];
					aux.Precio = (decimal)lector["Precio"];

					lista.Add(aux);
				}

				conexion.Close();
				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
