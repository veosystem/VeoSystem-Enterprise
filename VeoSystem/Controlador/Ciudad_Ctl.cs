using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo;
using VeoSystem.Modelo.Data;

namespace VeoSystem.Controlador
{
    public class Ciudad_Ctl
    {

        Ciudad_Cls objCiudad = new Ciudad_Cls();

        public List<Ciudad_Mdl> ListaCiudad(string Servidor, int idEstado)
        {
            return objCiudad.ListaCiudad(Servidor, idEstado);
        }

    }

}
