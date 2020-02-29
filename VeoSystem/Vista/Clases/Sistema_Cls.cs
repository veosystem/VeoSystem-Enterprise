using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeoSystem.Vista.Clases
{
    public static class Sistema_Cls
    {

        #region "Sucursal"

        public static int GblIntSucursal { get; set; } = 0;
        public static string GblStrSucursal { get; set; } = string.Empty;

        #endregion

        #region "Usuario"

        public static int GblIntUsuario { get; set; } = 0;

        #endregion

        #region "Licencia"

        public static string GblStrLicencia { get; set; } = string.Empty;

        #endregion

        #region "Servidor"

        public static string GblStrServidor { get; set; } = string.Empty;

        #endregion

        #region "Empresa"

        public static string GblStrEmpresa { get; set; } = string.Empty;

        #endregion

        #region "Funciones"

        public static string Encripta(string texto)
        {

            string result = string.Empty;
            byte[] encriyted = System.Text.Encoding.Unicode.GetBytes(texto);
            result = Convert.ToBase64String(encriyted);
            return result;

        }

        public static string DesEncripta(string texto)
        {

            string result = string.Empty;
            byte[] decrypted = Convert.FromBase64String(texto);
            result = System.Text.Encoding.Unicode.GetString(decrypted);
            return result;

        }

        #endregion

    }

}

