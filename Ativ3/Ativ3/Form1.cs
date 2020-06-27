using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ativ3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verify1, verify2, verify3;

            if (double.TryParse(txtValA.Text, out verify1) &&
                double.TryParse(txtValB.Text, out verify2) &&
                double.TryParse(txtValC.Text, out verify3))
            {
                if (verify1 < 0.00001 || verify2 < 0.00001 || verify3 < 0.00001)
                {
                    MessageBox.Show("Valores inválidos.");
                }
                else
                {
                    if (verify1 + verify2 < verify3 &&
                        verify1 + verify3 < verify2 && 
                        verify2 + verify3 < verify1)
                    {
                        MessageBox.Show("Não é triângulo");
                    }
                    else
                    {
                        if (verify1 == verify2 &&
                            verify2 == verify3)
                        {
                            MessageBox.Show("Triângulo equilátero.");
                        }
                        if (verify1 != verify2 &&
                            verify2 != verify3 &&
                            verify1 != verify3)
                        {
                            MessageBox.Show("Triângulo escaleno.");
                        }
                        if ((verify1 == verify2 && verify1 != verify3) ||
                            (verify2 == verify3 && verify2 != verify1) ||
                            (verify1 == verify3 && verify1 != verify2))
                        {
                            MessageBox.Show("Triângulo isóceles.");
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
