using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo;
using System.Data.SqlClient;
namespace VeoSystem.Modelo.Data
{
    public class Ciudad_Cls
    {

        Conexion objConexion = new Conexion();

        public List<Ciudad_Mdl> ListaCiudad(string Servidor, int idEstado)
        {

            List<Ciudad_Mdl> listaciudad = new List<Ciudad_Mdl>();

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Master(Servidor);
            if (cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;
                    strSql = "SELECT  ";
                    strSql += "id_ciudad, ";
                    strSql += "id_estado, ";
                    strSql += "ciudad ";
                    strSql += "FROM ";
                    strSql += "ciudad ";
                    strSql += "WHERE ";
                    strSql += "id_estado = " + idEstado + "";

                    cmdObj.CommandText = strSql;
                    SqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        Ciudad_Mdl objCiudad = new Ciudad_Mdl();

                        objCiudad.id_ciudad = Convert.ToInt32(rdrObj[0].ToString());
                        objCiudad.id_estado = Convert.ToInt32(rdrObj[1].ToString());
                        objCiudad.ciudad = rdrObj[2].ToString();

                        listaciudad.Add(objCiudad);

                    }

                    rdrObj.Close();

                }

            }

            return listaciudad;

        }

    }

}
