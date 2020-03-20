using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(txtRaio.Text, out verify1) &&
                double.TryParse(txtAltura.Text, out verify2)))
            {
                if (verify1 < 0 || verify2 < 0)
                    MessageBox.Show("Valores inválidos.");
                else
                {
                    double volume = Math.PI * (Math.Pow(verify1, 2)) * verify2;
                    txtVolume.Text = volume.ToString("N2");
                }
            }
            else
                MessageBox.Show("Dados inválidos.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = null;
            txtRaio.Text = null;
            txtVolume.Text = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
