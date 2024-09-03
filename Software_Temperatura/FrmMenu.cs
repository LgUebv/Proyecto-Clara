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
    public partial class FrmMenu : Form
    {
        private int nivelUsuario;

        public FrmMenu(int nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {
            // Configura la visibilidad de los controles según el nivel del usuario
            if (nivelUsuario == 1)
            {
                toggleButtons1.Visible = true;
                toggleButtons2.Visible = false;
                toggleButtons3.Visible = false;
            }
            else if (nivelUsuario == 2)
            {
                toggleButtons1.Visible = false;
                toggleButtons2.Visible = true;
                toggleButtons3.Visible = false;
            }
            else if (nivelUsuario == 3)
            {
                toggleButtons1.Visible = false;
                toggleButtons2.Visible = false;
                toggleButtons3.Visible = true;
            }
        }
    }
}
