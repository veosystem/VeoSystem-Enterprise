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
using VeoSystem.Controlador;

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
            string Licencia = string.Empty;

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
                VeoSystem.SetValue("Empresa", "", RegistryValueKind.String);
                VeoSystem.SetValue("Tipo", "", RegistryValueKind.String);
                VeoSystem.SetValue("Version", "", RegistryValueKind.String);

                Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString();

                if (Sistema_Cls.GblStrLicencia == "")
                {

                    frmLicencia frmlicencias = new frmLicencia();
                    if(frmlicencias.ShowDialog() == DialogResult.OK)
                    {

                        frmServidor frmservidor = new frmServidor();
                        if(frmservidor.ShowDialog() == DialogResult.OK)
                        {

                            Empresa_Ctl objEmpresa = new Empresa_Ctl();

                            Licencia = Sistema_Cls.DesEncripta(Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString());

                            BindingSource dbEmpresa = new BindingSource();
                            dbEmpresa.DataSource = objEmpresa.DatosEmpresa(Licencia);

                            frmEmpresa frmempresa = new frmEmpresa(dbEmpresa);
                            if(frmempresa.ShowDialog() == DialogResult.OK)
                            {
                                frmInicioSesion frminiciosesion = new frmInicioSesion();
                                if (frminiciosesion.ShowDialog() == DialogResult.OK)
                                {
                                    this.Show();
                                }
                            }

                        }
                        
                    }
                    
                }

            }
            else
            {

                equipoLocal = Registry.CurrentUser;
                equipoLocal = equipoLocal.OpenSubKey(@"Software", true);

                RegistryKey VeoSystem = equipoLocal.CreateSubKey("VeoSystem");

                Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString();
                Sistema_Cls.GblStrServidor = VeoSystem.GetValue("Servidor").ToString();
                Sistema_Cls.GblStrEmpresa = VeoSystem.GetValue("Empresa").ToString();

                this.Hide();

                if (Sistema_Cls.GblStrLicencia == "")
                {

                    frmLicencia frmlicencias = new frmLicencia();        
                    if(frmlicencias.ShowDialog() == DialogResult.OK)
                    {

                        frmServidor frmservidor = new frmServidor();
                        if (frmservidor.ShowDialog() == DialogResult.OK)
                        {

                            Empresa_Ctl objEmpresa = new Empresa_Ctl();

                            Licencia = Sistema_Cls.DesEncripta(Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString());

                            BindingSource dbEmpresa = new BindingSource();
                            dbEmpresa.DataSource = objEmpresa.DatosEmpresa(Licencia);

                            frmEmpresa frmempresa = new frmEmpresa(dbEmpresa);
                            if (frmempresa.ShowDialog() == DialogResult.OK)
                            {
                                frmInicioSesion frminiciosesion = new frmInicioSesion();
                                if (frminiciosesion.ShowDialog() == DialogResult.OK)
                                {
                                    this.Show();
                                }                   
                            }
                            else
                            {
                                this.Close();
                            }

                        }
                        else
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        this.Close();
                    }

                }
                else
                {

                    if(Sistema_Cls.GblStrServidor == "")
                    {

                        frmServidor frmservidor = new frmServidor();
                        if (frmservidor.ShowDialog() == DialogResult.OK)
                        {

                            Empresa_Ctl objEmpresa = new Empresa_Ctl();

                            Licencia = Sistema_Cls.DesEncripta(Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString());

                            BindingSource dbEmpresa = new BindingSource();
                            dbEmpresa.DataSource = objEmpresa.DatosEmpresa(Licencia);

                            frmEmpresa frmempresa = new frmEmpresa(dbEmpresa);
                            if (frmempresa.ShowDialog() == DialogResult.OK)
                            {
                                frmInicioSesion frminiciosesion = new frmInicioSesion();
                                if (frminiciosesion.ShowDialog() == DialogResult.OK)
                                {
                                    this.Show();
                                }
                            }
                            else
                            {
                                this.Close();
                            }

                        }
                        else
                        {
                            this.Close();
                        }

                    }
                    else
                    {

                        if(Sistema_Cls.GblStrEmpresa == "")
                        {

                            Empresa_Ctl objEmpresa = new Empresa_Ctl();

                            Licencia = Sistema_Cls.DesEncripta(Sistema_Cls.GblStrLicencia = VeoSystem.GetValue("Licencia").ToString());

                            BindingSource dbEmpresa = new BindingSource();
                            dbEmpresa.DataSource = objEmpresa.DatosEmpresa(Licencia);

                            frmEmpresa frmempresa = new frmEmpresa(dbEmpresa);
                            if (frmempresa.ShowDialog() == DialogResult.OK)
                            {

                                frmInicioSesion frminiciosesion = new frmInicioSesion();
                                if(frminiciosesion.ShowDialog() == DialogResult.OK)
                                {
                                    this.Show();
                                }        
                            }
                            else
                            {
                                this.Close();
                            }

                        }
                        else
                        {
                            frmInicioSesion frminiciosesion = new frmInicioSesion();
                            if (frminiciosesion.ShowDialog() == DialogResult.OK)
                            {


                                this.Show();
                            }
                            else
                            {
                                this.Close();
                            }
                        
                        }

                    }

                }

            }

        }

    }

}
