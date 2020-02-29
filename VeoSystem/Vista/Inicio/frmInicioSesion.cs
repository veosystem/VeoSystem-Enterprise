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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (IngresaSistema(txtUsuario.Text, txtPassword.Text) == true)
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Bienvenido " + txtUsuario.Text + " al Sistema","Credenciales Aceptadas",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta", "Error en los Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Focus();
            }

        }

        private Boolean IngresaSistema(string Usu, string Pass)
        {

            Boolean Resp = false;

            Inicio_Ctl objInicio = new Inicio_Ctl();
            DataTable dtUsuarios = new DataTable();
            dtUsuarios = objInicio.ListaUsuarios();

            foreach(DataRow dRow in dtUsuarios.Rows)
            {

                if(txtUsuario.Text == dRow["usuario"].ToString() && txtPassword.Text == Sistema_Cls.DesEncripta(dRow["password"].ToString()))
                {

                    if(Convert.ToInt32(dRow["cambio_pass"].ToString()) == 1)
                    {

                        frmCambiaPass frmcambiapass = new frmCambiaPass(Convert.ToInt32(dRow["id_usuario"].ToString()));
                        if(frmcambiapass.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }

                    }

                    Resp = true;
                }
                else
                {
                    Resp = false;
                }

            }

            return Resp;

        }

    }

}
