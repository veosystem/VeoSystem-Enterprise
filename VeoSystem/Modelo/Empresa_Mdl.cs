using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeoSystem.Modelo
{
    public  class Empresa_Mdl
    {

       public int id_cliente { get; set; }

       public string cliente { get; set; }

       public string razon_social { get; set; }

       public string rfc { get; set; }

       public string calle { get; set; }

       public string num_ext { get; set; }

       public string num_int { get; set; }

       public string colonia { get; set; }

       public string cod_postal { get; set; }

       public int id_pais { get; set; }

       public int id_estado { get; set; }

       public int id_ciudad { get; set; }

       public string contacto { get; set; }

       public string telefono { get; set; }

       public string correo { get; set; }

       public DateTime fecha_alta { get; set; }

       public DateTime fecha_baja { get; set; }

       public int id_licencia { get; set; }

       public string licencia { get; set; }

       public int id_tipo { get; set; }

       public int estatus { get; set; }

       public string tipo { get; set; }

       public string periodo { get; set; }

    }

}
