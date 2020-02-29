using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VeoSystem.Vista.Clases;

namespace VeoSystem.Modelo.Data
{
    public class Conexion
    {

        #region "Conexion Nube"

        public SqlConnection Conectar_Nube()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=localhost;initial catalog=veosystem_nube;user id=sa;password=Lu1salb3rt0";

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

        #endregion

        #region "Conexion Maestro"

        public SqlConnection Conectar_Master()
        {
            string Servidor;

            Servidor = Sistema_Cls.GblStrServidor;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=" + Servidor + ";initial catalog=veosystem_master;user id=sa;password=Lu1salb3rt0";

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

        public SqlConnection Conectar_Master(string Servidor)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=" + Servidor + ";initial catalog=veosystem_master;user id=sa;password=Lu1salb3rt0";

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

        #endregion

        #region "Conexion Sucursal"

        public SqlConnection Conectar()
        {

            string Sucursal;

            Sucursal = Sistema_Cls.GblStrSucursal;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "data source=localhost;initial catalog=" + Sucursal + ";user id=sa;password=Lu1salb3rt0";

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
            cn.ConnectionString = "data source=localhost;initial catalog=" + Sucursal + ";user id=sa;password=Lu1salb3rt0";

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

        #endregion



    }

}
