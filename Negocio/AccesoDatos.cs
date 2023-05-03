using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand cmd;
        private SqlDataReader lector;
        public SqlDataReader Lector { get { return lector; } }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            cmd = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = consulta;
            
        }

        public void ejecutarConsulta()
        {
            cmd.Connection = conexion;
            try
            {
                conexion.Open();
                lector = cmd.ExecuteReader();  //Ejecuta consulta en motor de base de datos y retorna un obj SqlDataReader el cual permite leer los registros que nos devuelve la consulta
            }catch (Exception ex)
            {
                throw ex;
            }           
            
        }
        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

        
    }
}
