using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo.Data;
using VeoSystem.Modelo;

namespace VeoSystem.Controlador
{
    public class Empresa_Ctl
    {

        Empresa_Cls objEmpresa = new Empresa_Cls();

        public List<Empresa_Mdl> Empresa(string Licencia)
        {
            return objEmpresa.Empresa(Licencia);
        }

        public List<Empresa_Mdl> DatosEmpresa(string Licencia)
        {
            return objEmpresa.DatosEmpresa(Licencia);
        }

        public int IngresaLicencia(string Licencia)
        {

            return objEmpresa.IngresaLicencia(Licencia);

        }

        public Boolean GuardaEmpresa(string Servidor, string Llave)
        {
            return objEmpresa.GuardaEmpresa(Servidor, Llave);
        }

    }

}
