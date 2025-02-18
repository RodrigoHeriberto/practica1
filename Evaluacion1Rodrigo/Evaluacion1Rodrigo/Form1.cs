using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1Rodrigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal precioFrijol_con_Queso = 0.35m;
        decimal precioQueso = 0.75m;
        decimal precioRevueltas = 0.50m;
        decimal precioPollo = 1.00m;
        decimal precioCamaron = 1.25m;
        decimal precioAgua = 0.50m;
        decimal precioCoca_Lata = 0.75m;
        decimal precioCoca_1Litro = 1.25m;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int cantidadFrijol_con_Queso = Convert.ToInt32(textBoxFrijol.Text);
            int cantidadQueso = Convert.ToInt32(textBoxQueso.Text);
            int cantidadRevueltas = Convert.ToInt32(textBoxRevueltas.Text);
            int cantidadPollo = Convert.ToInt32(textBoxPollo.Text);
            int cantidadCamaron = Convert.ToInt32(textBoxCamaron.Text);
            int cantidadAgua = Convert.ToInt32(textBoxAgua.Text);
            int cantidadCocaLata = Convert.ToInt32(textBoxlata.Text);
            int cantidadCocaLitro = Convert.ToInt32(textBox1Litro.Text);

            decimal total = (cantidadFrijol_con_Queso * precioFrijol_con_Queso) +
                            (cantidadQueso * precioQueso) +
                            (cantidadRevueltas * precioRevueltas) +
                            (cantidadPollo * precioPollo) +
                            (cantidadCamaron * precioCamaron) +
                            (cantidadAgua * precioAgua) +
                            (cantidadCocaLata * precioCoca_Lata) +
                            (cantidadCocaLitro * precioCoca_1Litro);
            textBoxTotal.Text = total.ToString("C");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

