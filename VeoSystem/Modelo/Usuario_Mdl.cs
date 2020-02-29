using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeoSystem.Modelo
{
    public class Usuario_Mdl
    {

        public int id_usuario { get; set; }

        public string usuario { get; set; }

        public string password { get; set; }

        public int id_rol { get; set; }

        public DateTime alta { get; set; }

        public DateTime baja { get; set; }

        public int estatus { get; set; }

        public int cambio_pass { get; set; }

    }

}
