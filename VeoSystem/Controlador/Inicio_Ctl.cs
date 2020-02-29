using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo;
using VeoSystem.Modelo.Data;

namespace VeoSystem.Controlador
{
    public class Inicio_Ctl
    {

        Inicio_Cls objInicio = new Inicio_Cls();
        public DataTable ListaUsuarios()
        {
            return objInicio.ListaUsuarios();
        }

        public Boolean CambiaPass(int idUsu, string Pass)
        {
            return objInicio.CambiaPass(idUsu, Pass);
        }

    }

}
