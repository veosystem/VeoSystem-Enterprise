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

namespace VeoSystem.Vista.Inicio
{
    public partial class frmServidor : Form
    {
        public frmServidor()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {

            Servidor_Ctl objServidor = new Servidor_Ctl();
           
            if(txtServidor.TextLength > 0)
            {

                if(objServidor.PruebaConexion(txtServidor.Text) == true)
                {
                    MessageBox.Show("Conexion Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo generar la conexion a su servidor, compruebe sus datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Servidor_Ctl objServidor = new Servidor_Ctl();


            if (txtServidor.TextLength > 0)
            {

                if (objServidor.PruebaConexion(txtServidor.Text) == true)
                {

                    RegistryKey equipoLocal = Registry.CurrentUser;
                    equipoLocal = equipoLocal.OpenSubKey(@"Software\\VeoSystem", true);

                    equipoLocal = Registry.CurrentUser;
                    equipoLocal = equipoLocal.OpenSubKey(@"Software", true);

                    RegistryKey VeoSystem = equipoLocal.CreateSubKey("VeoSystem");

                    VeoSystem.SetValue("Servidor", txtServidor.Text, RegistryValueKind.String);

                    MessageBox.Show("Conexion Guardada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se pudo generar la conexion a su servidor, compruebe sus datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

    }

}
