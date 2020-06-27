using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verify1, verify2, pesoVerificado;

            if ((double.TryParse(mskbxAltura.Text, out verify1) &&
                double.TryParse(mskbxPesoAtual.Text, out verify2)))
            {
                if (verify1 < 0 || verify2 < 0)
                {
                    MessageBox.Show("Valores inválidos.");
                }
                else
                {
                    if (rbtnFem.Checked)
                    {
                        if ((pesoVerificado = 62.1 * verify1 - 44.7) > verify1)
                        {
                            MessageBox.Show("Regime Obrigatório Já");
                        }
                        if ((pesoVerificado = 62.1 * verify1 - 44.7) == verify1)
                        {
                            MessageBox.Show("Você está com o peso ideal");
                        }
                        if ((pesoVerificado = 62.1 * verify1 - 44.7) < verify1)
                        {
                            MessageBox.Show("Coma bastante massas e doces");
                        }
                    }
                    else
                    {
                        if ((pesoVerificado = 72.7 * verify1 - 58) > verify1)
                        {
                            MessageBox.Show("Regime Obrigatório Já");
                        }
                        if ((pesoVerificado = 72.7 * verify1 - 58) == verify1)
                        {
                            MessageBox.Show("Você está com o peso ideal");
                        }
                        if ((pesoVerificado = 72.7 * verify1 - 58) < verify1)
                        {
                            MessageBox.Show("Coma bastante massas e doces");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos.");
            }
        }
    }
}
