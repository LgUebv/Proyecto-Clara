using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Label = System.Windows.Forms.Label;

namespace Controller
{
    public class ManejadorTemperaturas
    {
        private bool[] sensoresActivados;
        private double[] temperaturas;
        private Label[] labels;

        Funciones f = new Funciones();

        public ManejadorTemperaturas(bool[] sensoresActivados, Label[] labels)
        {
            this.sensoresActivados = sensoresActivados;
            this.labels = labels;
            this.temperaturas = new double[labels.Length];
        }

        public void GenerarValoresAleatorios()
        {
            Random random = new Random();
            for (int i = 0; i < sensoresActivados.Length; i++)
            {
                if (sensoresActivados[i])
                {
                    temperaturas[i] = random.NextDouble() * 100;
                }
            }
        }

        public void ActualizarEtiquetas()
        {
            for (int i = 0; i < labels.Length; i++)
            {
                if (sensoresActivados[i])
                {
                    labels[i].Text = temperaturas[i].ToString("F2");
                }
                else
                {
                    labels[i].Text = "---";
                }
            }
        }

        public void GuardarTemps()
        {
            for (int i = 0; i < temperaturas.Length; i++)
            {
                int estadoSensor = sensoresActivados[i] ? 1 : 0;

                if (sensoresActivados[i])
                {
                    // Guardar temperatura si el sensor está activado
                    f.Guardar($"INSERT INTO Registro_Temperatura (Numero_Sensor, Temperatura, Estado_Sensor) VALUES ({i + 1}, {temperaturas[i].ToString("F2")}, '{estadoSensor}')");
                }
                else
                {
                    // Guardar solo el estado si el sensor está desactivado
                    f.Guardar($"INSERT INTO Registro_Temperatura (Numero_Sensor, Estado_Sensor) VALUES ({i + 1}, '{estadoSensor}')");
                }
            }
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from V_Temps_General where  like '%{filtro}%'", "Usuarios").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
