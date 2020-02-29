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
    public partial class frmCambiaPass : Form
    {

        private int idUsu;
        public frmCambiaPass(int _idUsu)
        {
            InitializeComponent();
            idUsu = _idUsu;
        }


        private void CambiaPass()
        {

            Inicio_Ctl objInicio = new Inicio_Ctl();

            if(objInicio.CambiaPass(idUsu, Sistema_Cls.Encripta(txtContraseña.Text)) == true)
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtContraseña.Text = "";
                txtRepetir.Text = "";
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(txtContraseña.Text == txtRepetir.Text)
            {
                CambiaPass();
            }
            else
            {
                MessageBox.Show("Las contraseñas no corresponden, intente nuevamente", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

    }

}
