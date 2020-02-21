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
using VeoSystem.Vista.Clases;
using VeoSystem.Vista.Inicio;

namespace VeoSystem
{
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmMdi_Load(object sender, EventArgs e)
        {

            RegistryKey equipoLocal = Registry.CurrentUser;
            equipoLocal = equipoLocal.OpenSubKey(@"Software\\VeoSystem", true);

            if (equipoLocal == null)
            {

                this.Hide();

                equipoLocal = Registry.CurrentUser;
                equipoLocal = equipoLocal.OpenSubKey(@"Software", true);

                RegistryKey VeoSystem = equipoLocal.CreateSubKey("VeoSystem");

                VeoSystem.SetValue("Caja", 0, RegistryValueKind.String);
                VeoSystem.SetValue("Licencia", "", RegistryValueKind.String);
                VeoSystem.SetValue("FechaInst", "", RegistryValueKind.String);
                VeoSystem.SetValue("Servidor", "", RegistryValueKind.String);
                VeoSystem.SetValue("Tipo", "", RegistryValueKind.String);
                VeoSystem.SetValue("Version", "", RegistryValueKind.String);

                Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString();

                if(Sistema_Cls.GblStrLicencia == "")
                {

                    frmLicencia frmlicencias = new frmLicencia();
                    frmlicencias.MdiParent = this;
                    frmlicencias.Show();
                    
                }

            }
            else
            {

                equipoLocal = Registry.CurrentUser;
                equipoLocal = equipoLocal.OpenSubKey(@"Software", true);

                RegistryKey VeoSystem = equipoLocal.CreateSubKey("VeoSystem");

                Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString();

                if (Sistema_Cls.GblStrLicencia == "")
                {

                    frmLicencia frmlicencias = new frmLicencia();
                    frmlicencias.MdiParent = this;
                    frmlicencias.Show();

                }

            }

        }

    }

}
