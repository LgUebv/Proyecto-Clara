using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Temperatura
{
    public partial class FrmNuevoUsuario : Form
    {
        ManejadorUsuarios mu;
        public FrmNuevoUsuario()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if(FrmMenu.ID > 0)
            {
                txtUsername.Text = FrmMenu.Username.ToString();
                txtPassword.Text = FrmMenu.Password.ToString();
                txtNombre.Text = FrmMenu.Nombre.ToString();
                txtApellidos.Text = FrmMenu.Apellido.ToString();
                cmbNivel.Text = FrmMenu.Nivel.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FrmMenu.ID > 0)
            {
                mu.Modificar(txtUsername, txtPassword, txtNombre, txtApellidos, cmbNivel, FrmMenu.ID);
            }
            else
            {
                mu.Guardar(txtUsername, txtPassword, txtNombre, txtApellidos, cmbNivel);
            }
            Close();
        }
    }
}
