using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Form1 : Form
    {
        Dado dado = new Dado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = dado.lanzar().ToString();
        }

        private void btnLanzarX10_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            for (int i = 0; i < 10; i++)
            {
                txtResultado.Text += dado.lanzar().ToString() + Environment.NewLine;
            }
        }

        private void btnLanzarX100_Click(object sender, EventArgs e)
        {
            int[] conteo = { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 100; i++)
                conteo[dado.lanzar() - 1]++;

            txtResultado.Text = "";
            for(int i = 0; i < conteo.Length; i++)
                txtResultado.Text += (i + 1).ToString() + "  ->  " + conteo[i].ToString() + Environment.NewLine;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int[] suma = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 100; i++)
                suma[dado.lanzar() + dado.lanzar() - 2]++;

            txtResultado.Text = "";
            for (int i = 0; i < suma.Length; i++)
                txtResultado.Text += (i + 2).ToString() + "  ->  " + suma[i].ToString() + Environment.NewLine;
        }

        private void btnSuma2_Click(object sender, EventArgs e)
        {
            Dado dado1 = new Dado();
            Dado dado2 = new Dado();

            int[] suma = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 100; i++)
                suma[dado1.lanzar() + dado2.lanzar() - 2]++;

            txtResultado.Text = "";
            for (int i = 0; i < suma.Length; i++)
                txtResultado.Text += (i + 2).ToString() + "  ->  " + suma[i].ToString() + Environment.NewLine;
        }
    }
}