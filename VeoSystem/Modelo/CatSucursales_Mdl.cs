using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeoSystem.Modelo
{
    public class CatSucursales_Mdl
    {

        public int id_sucursal { get; set; }

        public int id_empresa { get; set; }

        public string sucursal { get; set; }

        public string calle { get; set; }

        public string num_ext { get; set; }

        public string num_int { get; set; }

        public string colonia { get; set; }

        public string cod_postal { get; set; }

        public int id_pais { get; set; }

        public int id_estado { get; set; }

        public int id_ciudad { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public string responsable { get; set; }

        public int estatus { get; set; }

        public DateTime alta { get; set; }

        public DateTime baja { get; set; }

    }

}
