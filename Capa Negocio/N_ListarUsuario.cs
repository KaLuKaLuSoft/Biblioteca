using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class N_ListarUsuario
    {
        public DataTable ListarUsuarios()
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ListarUsuario", cn);
                SqlDataReader LeerFilas;
                DataTable Tabla = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                LeerFilas = cmd.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                return Tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
