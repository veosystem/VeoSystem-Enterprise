using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeoSystem.Controlador;
using VeoSystem.Vista.Clases;

namespace VeoSystem.Vista.Inicio
{
    public partial class frmLicencia : Form
    {

        BindingSource dbEmpresa = new BindingSource();

        string Fecha = DateTime.Now.ToString("yyyyMMdd");

        public frmLicencia()
        {
            InitializeComponent();
        }

        #region "Llave"

        private void txtLlave1_TextChanged(object sender, EventArgs e)
        {

            if (txtLlave1.TextLength == 4)
            {
                txtLlave1.ReadOnly = true;
                txtLlave2.Focus();
            }

        }

        private void txtLlave2_TextChanged(object sender, EventArgs e)
        {

            if (txtLlave2.TextLength == 4)
            {
                txtLlave2.ReadOnly = true;
                txtLlave3.Focus();
            }

        }

        private void txtLlave3_TextChanged(object sender, EventArgs e)
        {

            if (txtLlave3.TextLength == 4)
            {
                txtLlave3.ReadOnly = true;
                txtLlave4.Focus();
            }

        }

        private void txtLlave4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back)
            {
                if (txtLlave4.TextLength == 0)
                {
                    txtLlave3.ReadOnly = false;
                    txtLlave3.Focus();
                }
            }

        }

        private void txtLlave3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back)
            {

                if (txtLlave3.TextLength == 0)
                {
                    txtLlave2.ReadOnly = false;
                    txtLlave2.Focus();
                }

            }

        }

        private void txtLlave2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back)
            {

                if (txtLlave2.TextLength == 0)
                {
                    txtLlave1.ReadOnly = false;
                    txtLlave1.Focus();
                }

            }

        }



        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string Llave;

            if(txtLlave1.TextLength > 0 && txtLlave2.TextLength > 0 && txtLlave3.TextLength > 0 && txtLlave4.TextLength > 0)
            {

                Llave = txtLlave1.Text + txtLlave2.Text + txtLlave3.Text + txtLlave4.Text;

                if (IngresaLicencia(Llave) == true)
                {
                   
                    MessageBox.Show("Licencia Ingresada Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Licencia no valida, favor de contactar a su proveedor","Error de Licencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }

        }

        private Boolean IngresaLicencia(string Llave)
        {

            Empresa_Ctl objEmpresa = new Empresa_Ctl();
     
            dbEmpresa.DataSource = objEmpresa.Empresa(Llave);
            if(dbEmpresa.Count > 0)
            {

                if(objEmpresa.IngresaLicencia(Llave) == 1)
                {

                    string Encriptado = string.Empty;
                    string FechaEncriptada = string.Empty;

                    Encriptado = Sistema_Cls.Encripta(Llave);
                    FechaEncriptada = Sistema_Cls.Encripta(Fecha);

                    RegistryKey equipoLocal = Registry.CurrentUser;
                    equipoLocal = equipoLocal.OpenSubKey(@"Software\\VeoSystem", true);

                    equipoLocal = Registry.CurrentUser;
                    equipoLocal = equipoLocal.OpenSubKey(@"Software", true);

                    RegistryKey VeoSystem = equipoLocal.CreateSubKey("VeoSystem");

                    VeoSystem.SetValue("Licencia", Encriptado, RegistryValueKind.String);
                    VeoSystem.SetValue("FechaInst", FechaEncriptada, RegistryValueKind.String);

                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
            
        }

    }

}
