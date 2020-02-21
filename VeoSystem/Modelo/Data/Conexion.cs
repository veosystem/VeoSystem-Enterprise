using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VeoSystem.Modelo.Data
{
    public class Conexion
    {

        public SqlConnection Conectar_Maestro()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=localhost;initial catalog=veosystem;user id=sa;password=Lu1salb3rt0";

            try
            {
                cn.Open();
                return cn;
            }
            catch
            {
                return null;
            }

        }

        public SqlConnection Conectar(string Sucursal)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=localhost;initial catalog="+ Sucursal +";user id=sa;password=Lu1salb3rt0";

            try
            {
                cn.Open();
                return cn;
            }
            catch
            {
                return null;
            }

        }

    }

}
