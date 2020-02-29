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
using VeoSystem.Controlador;
using Microsoft.Win32;

namespace VeoSystem.Vista.Inicio
{
    public partial class frmEmpresa : Form
    {

        BindingSource dbEmpresa = new BindingSource();

        public frmEmpresa(BindingSource Empresa)
        {
            InitializeComponent();
            dbEmpresa.DataSource = Empresa;
        }

        #region "LlenaCatalogos"
        
        private void LlenaCmbPais()
        {

            BindingSource dbPais = new BindingSource();
            Pais_Ctl objPais = new Pais_Ctl();

            dbPais.DataSource = objPais.ListaPais(Sistema_Cls.GblStrServidor);

            cmbPais.ValueMember = "id_pais";
            cmbPais.DisplayMember = "pais";
            cmbPais.DataSource = dbPais;

        }

        private void LlenaCmbEstado()
        {
           
            BindingSource dbEstado = new BindingSource();
            Estado_Ctl objEstado = new Estado_Ctl();
   
            dbEstado.DataSource = objEstado.ListaEstado(Sistema_Cls.GblStrServidor, Convert.ToInt32(cmbPais.SelectedValue));
                
            cmbEstado.ValueMember = "id_estado";     
            cmbEstado.DisplayMember = "estado";
            cmbEstado.DataSource = dbEstado;

        }

        private void LlenaCmbCiudad()
        {
   
            BindingSource dbCiudad = new BindingSource();
            Ciudad_Ctl objCiudad = new Ciudad_Ctl();

            dbCiudad.DataSource = objCiudad.ListaCiudad(Sistema_Cls.GblStrServidor, Convert.ToInt32(cmbEstado.SelectedValue));

            cmbCiudad.DataSource = dbCiudad;
            cmbCiudad.ValueMember = "id_ciudad";
            cmbCiudad.DisplayMember = "ciudad";
      
        }

        #endregion

        #region "Formulario"

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

            LlenaCmbEstado();

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            LlenaCmbCiudad();

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {

            LlenaDatos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            txtEmpresa.ReadOnly = false;
            txtRazonSocial.ReadOnly = false;
            txtCalle.ReadOnly = false;
            txtNumExt.ReadOnly = false;
            txtNumInt.ReadOnly = false;
            txtColonia.ReadOnly = false;
            txtCodPostal.ReadOnly = false;
            cmbEstado.Enabled = true;
            cmbCiudad.Enabled = true;
            txtContacto.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtCorreo.ReadOnly = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(GuardaEmpresa() == true)
            {
                RegistryKey equipoLocal = Registry.CurrentUser;
                equipoLocal = equipoLocal.OpenSubKey(@"Software\\VeoSystem", true);

                equipoLocal = Registry.CurrentUser;
                equipoLocal = equipoLocal.OpenSubKey(@"Software", true);

                RegistryKey VeoSystem = equipoLocal.CreateSubKey("VeoSystem");

                VeoSystem.SetValue("Empresa", txtEmpresa.Text, RegistryValueKind.String);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Close();
            }

        }

        #endregion

        #region "Funciones"

        private void LlenaDatos()
        {

            LlenaCmbPais();

            foreach (var dato in dbEmpresa)
            {

                txtEmpresa.DataBindings.Add("Text", dbEmpresa, "cliente");
                txtRazonSocial.DataBindings.Add("Text", dbEmpresa, "razon_social");
                txtRfc.DataBindings.Add("Text", dbEmpresa, "rfc");
                txtCalle.DataBindings.Add("Text", dbEmpresa, "calle");
                txtNumExt.DataBindings.Add("Text", dbEmpresa, "num_ext");
                txtNumInt.DataBindings.Add("Text", dbEmpresa, "num_int");
                txtColonia.DataBindings.Add("Text", dbEmpresa, "colonia");
                txtCodPostal.DataBindings.Add("Text", dbEmpresa, "cod_postal");

                cmbPais.DataBindings.Add("SelectedValue", dbEmpresa, "id_pais");
                cmbEstado.DataBindings.Add("SelectedValue", dbEmpresa, "id_estado");
                cmbCiudad.DataBindings.Add("SelectedValue", dbEmpresa, "id_ciudad");

                txtContacto.DataBindings.Add("Text", dbEmpresa, "contacto");
                txtTelefono.DataBindings.Add("Text", dbEmpresa, "telefono");
                txtCorreo.DataBindings.Add("Text", dbEmpresa, "correo");

            }

        }

        private Boolean GuardaEmpresa()
        {

            Empresa_Ctl objEmpresa = new Empresa_Ctl();

            if(objEmpresa.GuardaEmpresa(Sistema_Cls.GblStrServidor, Sistema_Cls.DesEncripta(Sistema_Cls.GblStrLicencia)) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        #endregion

    }

}
