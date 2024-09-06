using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Software_Temperatura
{
    public partial class FrmVistaTemps : Form
    {
        Funciones f = new Funciones();
        public FrmVistaTemps()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSensores_TextChanged(object sender, EventArgs e)
        {
            MostrarActivos(dtgvSensores, txtSensores.Text);
        }

        private void tgbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbMostrar.Checked)
            {
                dtgvSensores.Visible = true;
                MostrarGeneral(dtgvSensores, txtSensores.Text);
            }
            else
            {
                MostrarActivos(dtgvSensores, txtSensores.Text);
            }
        }

        public void MostrarActivos(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from V_Temps_Activados where Numero_Sensor like '%{filtro}%'", "Registro_Temperaturas").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarGeneral(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from V_Temps_General where Numero_Sensor like '%{filtro}%'", "Registro_Temperaturas").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
