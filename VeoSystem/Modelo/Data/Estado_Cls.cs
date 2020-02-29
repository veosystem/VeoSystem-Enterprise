using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo;
using System.Data.SqlClient;

namespace VeoSystem.Modelo.Data
{
    public class Estado_Cls
    {

        Conexion objConexion = new Conexion();

        public List<Estado_Mdl> ListaEstado(string Servidor, int idPais)
        {

            List<Estado_Mdl> listaestado = new List<Estado_Mdl>();

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Master(Servidor);
            if (cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;
                    strSql = "SELECT ";
                    strSql += "id_estado, ";
                    strSql += "id_pais, ";
                    strSql += "estado ";
                    strSql += "FROM ";
                    strSql += "estado ";
                    strSql += "WHERE ";
                    strSql += "id_pais = " + idPais + "";

                    cmdObj.CommandText = strSql;
                    SqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        Estado_Mdl objEstado = new Estado_Mdl();

                        objEstado.id_estado = Convert.ToInt32(rdrObj[0].ToString());
                        objEstado.id_pais = Convert.ToInt32(rdrObj[1].ToString());
                        objEstado.estado = rdrObj[2].ToString();

                        listaestado.Add(objEstado);

                    }

                    rdrObj.Close();

                }

            }

            return listaestado;
        
        }
   
    }

}
