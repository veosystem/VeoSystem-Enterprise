using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeoSystem.Modelo.Data
{
  
    public class CreaSucursal_Cls
    {

        Conexion objConexion = new Conexion();

        public int Inicio(string Sucursal)
        {

            /*************************************************************
             *                                                                                   *
             *              Iniciamos la creación de la base de             *
             *                                                                                   *
             *              datos junto con las tablas de la                    *
             *                                                                                   *
             *              sucursal                                                        *
             *                                                                                   *
            **************************************************************/

            int Mensaje = 0;

            if(CreaBaseDatos(Sucursal) == 1)
            {
                if(CrearTablas(Sucursal) == 1)
                {
                    Mensaje = 1;
                }
                else
                {
                    Mensaje = 0;
                }
                
            }
            else
            {
                Mensaje = 0;
            }

            return Mensaje;

        }

        private int CreaBaseDatos(string Sucursal)
        {

            int Mensaje = 0;

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Nube();

            if(cnObj != null)
            {
                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql = "";

                    strSql = "CREATE ";
                    strSql += "DATEBASE ";
                    strSql += "'" + Sucursal + "'";

                    cmdObj.CommandText = strSql;

                    try
                    {
                        cmdObj.ExecuteNonQuery();
                        Mensaje = 1;
                    }catch(SqlException ex)
                    {
                        MessageBox.Show("Error al Crear la Base de Datos, " + ex.Message.ToString(),"ERROR CRITICO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Mensaje = 0;
                    }

                }

            }

            return Mensaje;

        }

        private int CrearTablas(string Sucursal)
        {

            int Mensaje = 0;



            return Mensaje;

        }

    }

}
