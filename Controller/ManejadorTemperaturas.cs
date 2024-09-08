using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataAccess;
using Label = System.Windows.Forms.Label;

namespace Controller
{
    public class ManejadorTemperaturas
    {
        private bool[] sensoresActivados;
        private double[] temperaturas;
        private Label[] labels;
        private Chart[] charts;

        Funciones f = new Funciones();

        public ManejadorTemperaturas(bool[] sensoresActivados, Label[] labels, Chart[] charts)
        {
            this.sensoresActivados = sensoresActivados;
            this.labels = labels;
            this.temperaturas = new double[labels.Length];
            this.charts = charts;
        }

        public void GenerarValoresAleatorios()
        {
            Random random = new Random();
            for (int i = 0; i < sensoresActivados.Length; i++)
            {
                if (sensoresActivados[i])
                {
                    temperaturas[i] = random.NextDouble() * 100;
                    charts[i].Series[$"Sensor {i + 1}"].Points.AddY(temperaturas[i]);

                    if (charts[i].Series[$"Sensor {i + 1}"].Points.Count > 100)
                    {
                        charts[i].Series[$"Sensor {i + 1}"].Points.RemoveAt(0);
                    }
                }
            }
            foreach (var chart in charts)
            {
                chart.Invalidate();
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
                    f.Guardar($"INSERT INTO Registro_Temperatura (Numero_Sensor, Temperatura, Estado_Sensor) VALUES ({i + 1}, {temperaturas[i].ToString("F2")}, '{estadoSensor}')");
                }
                else
                {
                    f.Guardar($"INSERT INTO Registro_Temperatura (Numero_Sensor, Estado_Sensor) VALUES ({i + 1}, '{estadoSensor}')");
                }
            }
        }
    }
}
