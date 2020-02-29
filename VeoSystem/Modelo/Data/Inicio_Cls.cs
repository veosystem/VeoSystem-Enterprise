using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeoSystem.Modelo;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace VeoSystem.Modelo.Data
{
    public class Inicio_Cls
    {

        Conexion objConexion = new Conexion();

        public DataTable ListaUsuarios()
        {

            DataTable dtlistausuarios = new DataTable();

            dtlistausuarios.Columns.Add("id_usuario");
            dtlistausuarios.Columns.Add("usuario");
            dtlistausuarios.Columns.Add("password");
            dtlistausuarios.Columns.Add("id_rol");
            dtlistausuarios.Columns.Add("alta");
            dtlistausuarios.Columns.Add("baja");
            dtlistausuarios.Columns.Add("estatus");
            dtlistausuarios.Columns.Add("cambio_pass");

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Master();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "SELECT ";
                    strSql += "id_usuario, ";
                    strSql += "usuario, ";
                    strSql += "password, ";
                    strSql += "id_rol, ";
                    strSql += "alta, ";
                    strSql += "baja, ";
                    strSql += "estatus, ";
                    strSql += "cambio_pass ";
                    strSql += "FROM ";
                    strSql += "usuario";

                    cmdObj.CommandText = strSql;
                    SqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        DataRow dRow = dtlistausuarios.NewRow();

                        dRow["id_usuario"] = Convert.ToInt32(rdrObj[0].ToString());
                        dRow["usuario"] = rdrObj[1].ToString();
                        dRow["password"] = rdrObj[2].ToString();
                        dRow["id_rol"] = Convert.ToInt32(rdrObj[3].ToString());
                        dRow["alta"] = rdrObj[4].ToString();
                        dRow["baja"] = rdrObj[5].ToString();
                        dRow["estatus"] = Convert.ToInt32(rdrObj[6].ToString());
                        dRow["cambio_pass"] = Convert.ToInt32(rdrObj[7].ToString());

                        dtlistausuarios.Rows.Add(dRow);

                    }

                    rdrObj.Close();

                }

            }

            return dtlistausuarios;

        }

        public Boolean CambiaPass(int idUsu, string Pass)
        {

            Boolean Resp = false;

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Master();

            if(cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "UPDATE ";
                    strSql += "usuario ";
                    strSql += "SET ";
                    strSql += "cambio_pass = 0, ";
                    strSql += "password = '" + Pass + "' ";
                    strSql += "WHERE ";
                    strSql += "id_usuario = " + idUsu + "";

                    cmdObj.CommandText = strSql;

                    try
                    {
                        cmdObj.ExecuteNonQuery();
                        Resp = true;
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Error al Actualizar la Contraseña, " + ex.Message,"Error Critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Resp = false;
                    }

                }

            }

            return Resp;

        }

    }

}
