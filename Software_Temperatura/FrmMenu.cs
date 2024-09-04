using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace Software_Temperatura
{
    public partial class FrmMenu : Form
    {
        ManejadorUsuarios mu = new ManejadorUsuarios();

        private int nivelUsuario;
        public static int ID = 0, Nivel = 0;
        public static string Username, Password, Nombre, Apellido = "";
        int fila = 0, columna = 0;

        public FrmMenu(int nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
            ConfigurarMenu();
            pnlSensores.Visible = true;
            pnlUsuarios.Visible = false;
        }

        private void ConfigurarMenu()
        {
            if (nivelUsuario == 1)
            {
                ptbSensores.Visible = true;
                ptbUsers.Visible = true;
            }
            else if (nivelUsuario == 2)
            {
                ptbSensores.Visible = true;
                ptbUsers.Visible = false;
            }
            else if (nivelUsuario == 3)
            {
                ptbSensores.Visible = true;
                ptbUsers.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void ptbUsers_Paint(object sender, PaintEventArgs e)
        {
            string texto = "Usuarios";
            Font fuente = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            Brush brocha = Brushes.Black;
            Point ubicacion = new Point(10, 10);
            e.Graphics.DrawString(texto, fuente, brocha, ubicacion);
        }

        private void txtUsuarios_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible = true;
            mu.Mostrar(dtgvUsuarios, txtUsuarios.Text);
        }

        private void dtgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 4:
                    {
                        ID = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        mu.Borrar(ID, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString());
                        dtgvUsuarios.Visible = false;
                    }
                    break;
                case 5:
                    {
                        ID = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        Username = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                        Nombre = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                        Apellido = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                        Nivel = int.Parse(dtgvUsuarios.Rows[fila].Cells[4].Value.ToString());
                        FrmNuevoUsuario AddUser = new FrmNuevoUsuario();
                        AddUser.ShowDialog();
                        dtgvUsuarios.Visible = false;
                    }
                    break;
            }
        }

        private void ptbSensores_Paint(object sender, PaintEventArgs e)
        {
            string texto = "Sensores";
            Font fuente = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            Brush brocha = Brushes.Black;
            Point ubicacion = new Point(10, 10);
            e.Graphics.DrawString(texto, fuente, brocha, ubicacion);
        }

        private void ptbSensores_Click(object sender, EventArgs e)
        {
            pnlSensores.Visible = true;
            pnlUsuarios.Visible = false;
        }

        private void ptbUsers_Click(object sender, EventArgs e)
        {
            pnlSensores.Visible = false;
            pnlUsuarios.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Username = ""; Nombre = ""; Apellido = ""; Nivel = 0;
            dtgvUsuarios.Visible = false;
            FrmNuevoUsuario AddUser = new FrmNuevoUsuario();
            AddUser.ShowDialog();
            txtUsuarios.Focus();
        }
    }
}
