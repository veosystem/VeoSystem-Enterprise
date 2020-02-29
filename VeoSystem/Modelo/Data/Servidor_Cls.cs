using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VeoSystem.Modelo.Data
{
    public class Servidor_Cls
    {

        public Boolean PruebaConexion(string Servidor)
        {

            Conexion objConexion = new Conexion();
            SqlConnection cnObj = new SqlConnection();

            cnObj = objConexion.Conectar_Master(Servidor);
            if(cnObj != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
