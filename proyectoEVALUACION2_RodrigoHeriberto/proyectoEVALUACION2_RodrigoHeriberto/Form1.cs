using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUACION2_RodrigoHeriberto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //aqui se obtienen y se validan las notas
                double teo1 = ObtenerNota(textBox1.Text);
                double teo2 = ObtenerNota(textBox2.Text);
                double teo3 = ObtenerNota(textBox3.Text);
                double labo1 = ObtenerNota(textBox4.Text);
                double labo2 = ObtenerNota(textBox5.Text);
                double labo3 = ObtenerNota(textBox6.Text);

                //aqui calcula el promedio final
                double promedio = (teo1 + teo2 + teo3 + labo1 + labo2 + labo3) / 6;

                //aqui muestra el promedio
                label1.Text = $"Nota Promedio: {promedio:F2}";

                if (promedio >= 7.0)
                {
                    label2.Text = "Grandioso, Excelente… continúa así…";
                    pictureBox1.Image = Properties.Resources.Excellent;
                }
                else if (promedio >= 6.0)
                {
                    label2.Text = "Muy bien… pero trata de mejorar tu promedio en las siguientes materias";
                    pictureBox1.Image = Properties.Resources.bien;
                }
                else if (promedio >= 3.0)
                {
                    label2.Text = "Más dedicación estudiante, debe mejorar sus notas en esta materia y las del resto";
                    pictureBox1.Image = Properties.Resources.Mas_dedicacion;
                }
                else
                {
                    label2.Text = "Pongase las pilas mi hijito, ya no está en el Kinder… No se convierta en un veterano de INDEL";
                    pictureBox1.Image = Properties.Resources.Mal2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ObtenerNota(string textoNota)
        {
            if (!double.TryParse(textoNota, out double nota) || nota < 0.00 || nota > 10.00)
            {
                throw new ArgumentException("Por favor, ingrese una nota válida entre 0.00 y 10.00.");
            }
            return nota;
        }
    }
}

