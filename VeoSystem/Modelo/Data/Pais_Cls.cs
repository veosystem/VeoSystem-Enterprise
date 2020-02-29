using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo;
using System.Data.SqlClient;

namespace VeoSystem.Modelo.Data
{
    public class Pais_Cls
    {

        Conexion objConexion = new Conexion();

        public List<Pais_Mdl> ListaPais(string Servidor)
        {

            List<Pais_Mdl> listapais = new List<Pais_Mdl>();

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Master(Servidor);
            if(cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_pais, ";
                    strSql += "pais ";
                    strSql += "FROM ";
                    strSql += "pais";

                    cmdObj.CommandText = strSql;
                    SqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        Pais_Mdl objPais = new Pais_Mdl();
                        objPais.id_pais = Convert.ToInt32(rdrObj[0].ToString());
                        objPais.pais = rdrObj[1].ToString();

                        listapais.Add(objPais);

                    }

                    rdrObj.Close();
                }

            }

            return listapais;
        }
                
    }

}
