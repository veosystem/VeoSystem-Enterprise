using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo.Data;

namespace VeoSystem.Controlador
{
    public class Servidor_Ctl
    {

        Servidor_Cls objServidor = new Servidor_Cls();

        public Boolean PruebaConexion(string Servidor)
        {
            return objServidor.PruebaConexion(Servidor);

        }

    }

}
