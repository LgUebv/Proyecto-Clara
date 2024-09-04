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
        ManejadorTemperaturas mt;

        private int nivelUsuario;
        public static int ID = 0, Nivel = 0;
        public static string Username, Password, Nombre, Apellido = "";
        int fila = 0, columna = 0;

        bool[] sensoresActivados = new bool[15];

        public FrmMenu(int nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
            ConfigurarMenu();

            Label[] labels = { label19, label20, label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33 };
            mt = new ManejadorTemperaturas(sensoresActivados, labels);
            tmrTemps.Start();
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
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label31.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
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

        private void btnS1Z1_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[0] = !sensoresActivados[0];
        }

        private void btnS2Z1_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[1] = !sensoresActivados[1];
        }

        private void btnS3Z1_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[2] = !sensoresActivados[2];
        }

        private void btnS4Z1_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[3] = !sensoresActivados[3];
        }

        private void btnS5Z1_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[4] = !sensoresActivados[4];
        }

        private void btnS1Z2_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[5] = !sensoresActivados[5];
        }

        private void btnS2Z2_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[6] = !sensoresActivados[6];
        }

        private void btnS3Z2_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[7] = !sensoresActivados[7];
        }

        private void btnS4Z2_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[8] = !sensoresActivados[8];
        }

        private void btnS5Z2_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[9] = !sensoresActivados[9];
        }

        private void btnS1Z3_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[10] = !sensoresActivados[10];
        }

        private void btnS2Z3_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[11] = !sensoresActivados[11];
        }

        private void btnS3Z3_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[12] = !sensoresActivados[12];
        }

        private void btnS4Z3_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[13] = !sensoresActivados[13];
        }

        private void btnS5Z3_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[14] = !sensoresActivados[14];
        }

        private void tmrTemps_Tick(object sender, EventArgs e)
        {
            mt.GenerarValoresAleatorios();
            mt.ActualizarEtiquetas();
        }

        private void ptbSensores_Paint(object sender, PaintEventArgs e)
        {
            string texto = "Sensores";
            Font fuente = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            Brush brocha = Brushes.Black;
            Point ubicacion = new Point(10, 10);
            e.Graphics.DrawString(texto, fuente, brocha, ubicacion);
        }

        private void ptbUsers_Paint(object sender, PaintEventArgs e)
        {
            string texto = "Usuarios";
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
