using System.Configuration;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            cn.Open();
            return cn;

        }
    }
}
