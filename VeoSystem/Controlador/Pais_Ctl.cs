using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo.Data;
using VeoSystem.Modelo;

namespace VeoSystem.Controlador
{
  
    public class Pais_Ctl
    {

        Pais_Cls objPais = new Pais_Cls();

        public List<Pais_Mdl> ListaPais(string Servidor)
        {
            return objPais.ListaPais(Servidor);
        }

    }

}
