using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
using Capa_Logica;

namespace Capa_Negocio
{
    public class N_ActualizarUsuario
    {
        public bool ActualizarUsuario(L_Usuario objl)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", objl.id);
            cmd.Parameters.AddWithValue("@nombre", objl.nombre);
            cmd.Parameters.AddWithValue("@APaterno", objl.APaterno);
            cmd.Parameters.AddWithValue("@AMaterno", objl.AMaterno);
            cmd.Parameters.AddWithValue("@correo", objl.correo);
            cmd.Parameters.AddWithValue("@TFijo", objl.TFijo);
            cmd.Parameters.AddWithValue("@TCelular", objl.TCelular);
            if (cmd.ExecuteNonQuery() == 1)
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }
        }
    }
}
