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

            Label[] labels = { label19, label24 };
            mt = new ManejadorTemperaturas(sensoresActivados, labels);
            tmrTemps.Start();
            tmrSaveTemps.Start();
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
                label24.Visible = false;
            }
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

        private void btnS1Z2_CheckedChanged(object sender, EventArgs e)
        {
            sensoresActivados[1] = !sensoresActivados[5];
        }

        private void tmrTemps_Tick(object sender, EventArgs e)
        {
            mt.GenerarValoresAleatorios();
            mt.ActualizarEtiquetas();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void tmrSaveTemps_Tick(object sender, EventArgs e)
        {
            mt.GuardarTemps();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
