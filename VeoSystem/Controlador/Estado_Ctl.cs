using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo;
using VeoSystem.Modelo.Data;

namespace VeoSystem.Controlador
{
    public class Estado_Ctl
    {

        Estado_Cls objEstado = new Estado_Cls();

        public List<Estado_Mdl> ListaEstado(string Servidor, int idPais)
        {
            return objEstado.ListaEstado(Servidor, idPais);
        }

    }

}
