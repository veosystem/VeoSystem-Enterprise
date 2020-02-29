using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VeoSystem.Modelo;
using System.Windows.Forms;
using System.Data;

namespace VeoSystem.Modelo.Data
{
    public class Empresa_Cls
    {

        Conexion objConexion = new Conexion();

        public List<Empresa_Mdl> Empresa(string Licencia)
        {

            List<Empresa_Mdl> listaEmpresa = new List<Empresa_Mdl>();

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Nube();

            if(cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql = "";

                    strSql = "SELECT ";
                    strSql += "a.id_cliente, ";
                    strSql += "a.cliente, ";
                    strSql += "a.razon_social, ";
                    strSql += "a.rfc, ";
                    strSql += "a.calle, ";
                    strSql += "a.num_ext, ";
                    strSql += "a.num_int, ";
                    strSql += "a.colonia, ";
                    strSql += "a.cod_postal, ";
                    strSql += "a.id_pais, ";
                    strSql += "a.id_estado, ";
                    strSql += "a.id_ciudad, ";
                    strSql += "a.contacto, ";
                    strSql += "a.telefono, ";
                    strSql += "a.correo, ";
                    strSql += "a.fecha_alta, ";
                    strSql += "a.fecha_baja, ";
                    strSql += "c.id_licencia, ";
                    strSql += "c.licencia, ";
                    strSql += "d.id_tipo, ";
                    strSql += "c.estatus, ";
                    strSql += "d.tipo, ";
                    strSql += "d.periodo ";
                    strSql += "FROM ";
                    strSql += "clientes a, ";
                    strSql += "licencia_cliente b, ";
                    strSql += "licencias c, ";
                    strSql += "tipo_licencia d ";
                    strSql += "WHERE ";
                    strSql += "a.id_cliente = b.id_cliente and ";
                    strSql += "b.id_licencia = c.id_licencia and ";
                    strSql += "c.id_tipo = d.id_tipo and ";
                    strSql += "c.licencia = '" + Licencia + "' AND ";
                    strSql += "c.estatus = 1";

                    cmdObj.CommandText = strSql;
                    SqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        Empresa_Mdl objEmpresa = new Empresa_Mdl();

                        objEmpresa.id_cliente = Convert.ToInt32(rdrObj[0].ToString());
                        objEmpresa.cliente = rdrObj[1].ToString();
                        objEmpresa.razon_social = rdrObj[2].ToString();
                        objEmpresa.rfc = rdrObj[3].ToString();
                        objEmpresa.calle = rdrObj[4].ToString();
                        objEmpresa.num_ext = rdrObj[5].ToString();
                        objEmpresa.num_int = rdrObj[6].ToString();
                        objEmpresa.colonia = rdrObj[7].ToString();
                        objEmpresa.cod_postal = rdrObj[8].ToString();
                        objEmpresa.id_pais = Convert.ToInt32(rdrObj[9].ToString());
                        objEmpresa.id_estado = Convert.ToInt32(rdrObj[10].ToString());
                        objEmpresa.id_ciudad = Convert.ToInt32(rdrObj[11].ToString());
                        objEmpresa.contacto = rdrObj[12].ToString();
                        objEmpresa.telefono = rdrObj[13].ToString();
                        objEmpresa.correo = rdrObj[14].ToString();
                        objEmpresa.fecha_alta = Convert.ToDateTime(rdrObj[15].ToString());
                        objEmpresa.fecha_baja = Convert.ToDateTime(rdrObj[16].ToString());
                        objEmpresa.id_licencia = Convert.ToInt32(rdrObj[17].ToString());
                        objEmpresa.licencia = rdrObj[18].ToString();
                        objEmpresa.id_tipo = Convert.ToInt32(rdrObj[19].ToString());
                        objEmpresa.estatus = Convert.ToInt32(rdrObj[20].ToString());
                        objEmpresa.tipo = rdrObj[21].ToString();
                        objEmpresa.periodo = rdrObj[22].ToString();

                        listaEmpresa.Add(objEmpresa);

                    }

                    rdrObj.Close();

                }

            }

            return listaEmpresa;

        }        

        public int IngresaLicencia(string Licencia)
        {

            int Resp = 0;

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Nube();

            if(cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;

                    strSql = "UPDATE ";
                    strSql += "licencias ";
                    strSql += "SET ";
                    strSql += "estatus = 0 ";
                    strSql += "WHERE ";
                    strSql += "licencia = '" + Licencia + "'";

                    cmdObj.CommandText = strSql;

                    try
                    {
                        cmdObj.ExecuteNonQuery();
                        Resp = 1;
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("Error al Ingresar la Licencia, Favor de contactar a su proveedor. " + ex.Message,"Error Critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Resp = 0;
                    }

                }

            }

            return Resp;

        }

        public List<Empresa_Mdl> DatosEmpresa(string Licencia)
        {

            List<Empresa_Mdl> listaEmpresa = new List<Empresa_Mdl>();

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Nube();

            if (cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql = "";

                    strSql = "SELECT ";
                    strSql += "a.id_cliente, ";
                    strSql += "a.cliente, ";
                    strSql += "a.razon_social, ";
                    strSql += "a.rfc, ";
                    strSql += "a.calle, ";
                    strSql += "a.num_ext, ";
                    strSql += "a.num_int, ";
                    strSql += "a.colonia, ";
                    strSql += "a.cod_postal, ";
                    strSql += "a.id_pais, ";
                    strSql += "a.id_estado, ";
                    strSql += "a.id_ciudad, ";
                    strSql += "a.contacto, ";
                    strSql += "a.telefono, ";
                    strSql += "a.correo, ";
                    strSql += "a.fecha_alta, ";
                    strSql += "a.fecha_baja, ";
                    strSql += "c.id_licencia, ";
                    strSql += "c.licencia, ";
                    strSql += "d.id_tipo, ";
                    strSql += "c.estatus, ";
                    strSql += "d.tipo, ";
                    strSql += "d.periodo ";
                    strSql += "FROM ";
                    strSql += "clientes a, ";
                    strSql += "licencia_cliente b, ";
                    strSql += "licencias c, ";
                    strSql += "tipo_licencia d ";
                    strSql += "WHERE ";
                    strSql += "a.id_cliente = b.id_cliente and ";
                    strSql += "b.id_licencia = c.id_licencia and ";
                    strSql += "c.id_tipo = d.id_tipo and ";
                    strSql += "c.licencia = '" + Licencia + "'";
                  
                    cmdObj.CommandText = strSql;
                    SqlDataReader rdrObj = cmdObj.ExecuteReader();

                    while (rdrObj.Read())
                    {

                        Empresa_Mdl objEmpresa = new Empresa_Mdl();

                        objEmpresa.id_cliente = Convert.ToInt32(rdrObj[0].ToString());
                        objEmpresa.cliente = rdrObj[1].ToString();
                        objEmpresa.razon_social = rdrObj[2].ToString();
                        objEmpresa.rfc = rdrObj[3].ToString();
                        objEmpresa.calle = rdrObj[4].ToString();
                        objEmpresa.num_ext = rdrObj[5].ToString();
                        objEmpresa.num_int = rdrObj[6].ToString();
                        objEmpresa.colonia = rdrObj[7].ToString();
                        objEmpresa.cod_postal = rdrObj[8].ToString();
                        objEmpresa.id_pais = Convert.ToInt32(rdrObj[9].ToString());
                        objEmpresa.id_estado = Convert.ToInt32(rdrObj[10].ToString());
                        objEmpresa.id_ciudad = Convert.ToInt32(rdrObj[11].ToString());
                        objEmpresa.contacto = rdrObj[12].ToString();
                        objEmpresa.telefono = rdrObj[13].ToString();
                        objEmpresa.correo = rdrObj[14].ToString();
                        objEmpresa.fecha_alta = Convert.ToDateTime(rdrObj[15].ToString());
                        objEmpresa.fecha_baja = Convert.ToDateTime(rdrObj[16].ToString());
                        objEmpresa.id_licencia = Convert.ToInt32(rdrObj[17].ToString());
                        objEmpresa.licencia = rdrObj[18].ToString();
                        objEmpresa.id_tipo = Convert.ToInt32(rdrObj[19].ToString());
                        objEmpresa.estatus = Convert.ToInt32(rdrObj[20].ToString());
                        objEmpresa.tipo = rdrObj[21].ToString();
                        objEmpresa.periodo = rdrObj[22].ToString();

                        listaEmpresa.Add(objEmpresa);

                    }

                    rdrObj.Close();

                }

            }

            return listaEmpresa;

        }

        public Boolean GuardaEmpresa(string Servidor,string Llave)
        {

            Boolean Resp = false;

            SqlConnection cnObj = new SqlConnection();
            cnObj = objConexion.Conectar_Master(Servidor);
            if(cnObj != null)
            {

                using (cnObj)
                {

                    SqlCommand cmdObj = new SqlCommand();
                    cmdObj.Connection = cnObj;

                    string strSql;
                    List<Empresa_Mdl> listaempresa = new List<Empresa_Mdl>();
                    listaempresa = DatosEmpresa(Llave);

                    foreach(var dato in listaempresa)
                    {

                        strSql = "INSERT ";
                        strSql += "INTO ";
                        strSql += "empresa ";
                        strSql += "(empresa, ";
                        strSql += "razon_social, ";
                        strSql += "rfc, ";
                        strSql += "calle, ";
                        strSql += "num_ext, ";
                        strSql += "num_int, ";
                        strSql += "colonia, ";
                        strSql += "cod_postal, ";
                        strSql += "id_pais, ";
                        strSql += "id_estado, ";
                        strSql += "id_ciudad, ";
                        strSql += "contacto, ";
                        strSql += "telefono, ";
                        strSql += "correo, ";
                        strSql += "fecha_alta, ";
                        strSql += "fecha_baja, ";
                        strSql += "estatus) ";
                        strSql += "VALUES ";
                        strSql += "('" + dato.cliente + "', ";
                        strSql += "'" + dato.razon_social + "', ";
                        strSql += "'" + dato.rfc + "', ";
                        strSql += "'" + dato.calle + "', ";
                        strSql += "'" + dato.num_ext + "', ";
                        strSql += "'" + dato.num_int + "', ";
                        strSql += "'" + dato.colonia + "', ";
                        strSql += "'" + dato.cod_postal + "', ";
                        strSql += "" + dato.id_pais + ", ";
                        strSql += "" + dato.id_estado + ", ";
                        strSql += "" + dato.id_ciudad + ", ";
                        strSql += "'" + dato.contacto + "', ";
                        strSql += "'" + dato.telefono + "', ";
                        strSql += "'" + dato.correo + "', ";
                        strSql += "'" + dato.fecha_alta + "', ";
                        strSql += "'" + dato.fecha_baja + "', ";
                        strSql += "'" + dato.estatus + "')";

                        cmdObj.CommandText = strSql;

                        try
                        {
                            cmdObj.ExecuteNonQuery();
                            Resp = true;
                        }
                        catch(SqlException ex)
                        {
                            MessageBox.Show("Error al Ingresar la Empresa, " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Resp = false;
                        }

                    }

                }

            }

            return Resp;

        }

    }

}
