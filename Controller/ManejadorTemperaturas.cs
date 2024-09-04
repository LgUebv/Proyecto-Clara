using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Controller
{
    public class ManejadorTemperaturas
    {
        // Declarar los arreglos necesarios
        private bool[] sensoresActivados;
        private double[] temperaturas;
        private Label[] labels;

        // Constructor para inicializar los arreglos y recibir referencias desde el formulario
        public ManejadorTemperaturas(bool[] sensoresActivados, Label[] labels)
        {
            this.sensoresActivados = sensoresActivados;
            this.labels = labels;
            this.temperaturas = new double[labels.Length]; // Inicializa el arreglo de temperaturas
        }

        // Manejador del evento Tick del temporizador


        // Método para generar valores aleatorios
        public void GenerarValoresAleatorios()
        {
            Random random = new Random();
            for (int i = 0; i < sensoresActivados.Length; i++)
            {
                if (sensoresActivados[i])
                {
                    temperaturas[i] = random.NextDouble() * 100; // Genera una temperatura entre 0 y 100
                }
            }
        }

        // Método para actualizar las etiquetas
        public void ActualizarEtiquetas()
        {
            for (int i = 0; i < labels.Length; i++)
            {
                if (sensoresActivados[i])
                {
                    labels[i].Text = temperaturas[i].ToString("F2"); // Mostrar temperatura con 2 decimales
                }
                else
                {
                    labels[i].Text = "---"; // Mostrar indicador para sensores inactivos
                }
            }
        }
    }
}
