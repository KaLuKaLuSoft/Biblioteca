using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class L_Usuario
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string correo { get; set; }
        public int TFijo { get; set; }
        public int TCelular { get; set; }
    }
}
