using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeoSystem.Modelo
{
    public class CatUsuario_Mdl
    {

        public int idUsuario { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }

        public int idRol { get; set; }

        public int Estatus { get; set; }

        public int CambioPass { get; set; }

    }

}
