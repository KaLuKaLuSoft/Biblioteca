using Capa_Datos;
using Capa_Logica;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    public class N_InsertarUsuario
    {
        public bool InsertarUsuarios(L_Usuario objl)
        {
            SqlConnection cn = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
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
