using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ativ4
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

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            double verifySalBruto, salLiquido, pINSS = 0, pIRPF = 0, valINSS=0, valIRPF=0, salFamilia = 0;
            int verifyNumFilhos;
            string nomeFunc = mskbxNomeFunc.Text;

            try
            {
                verifySalBruto = Convert.ToDouble(mskbxSalBruto.Text);
                verifyNumFilhos = Convert.ToInt32(mskbxNumFilhos.Text);
                if (verifySalBruto <= 0)
                {
                    MessageBox.Show("Salário inválido.");
                }
                else
                {
                    if (verifySalBruto <= 800.47)
                    {
                        mskbxAliqINSS.Text = "7,65%";
                        pINSS = 0.0765;
                    }
                    if (verifySalBruto >= 800.48 && verifySalBruto <= 1050)
                    {
                        mskbxAliqINSS.Text = "8,65%";
                        pINSS = 0.0865;
                    }
                    if (verifySalBruto >= 1050.1 && verifySalBruto <= 1400.77)
                    {
                        mskbxAliqINSS.Text = "9,00%";
                        pINSS = 0.09;
                    }
                    if (verifySalBruto >= 1400.78 && verifySalBruto <= 2801.56)
                    {
                        mskbxAliqINSS.Text = "11,00%";
                        pINSS = 0.11;
                    }
                    if (verifySalBruto > 2801.56)
                    {
                        mskbxAliqINSS.Text = "Teto.";
                        valINSS = 308.17;
                        pINSS = 0;
                    }
                    if (verifySalBruto <= 1257.12)
                    {
                        mskbxAliqIRPF.Text = "Isento.";
                    }
                    if (verifySalBruto >= 1257.13 && verifySalBruto <= 2512.08)
                    {
                        mskbxAliqIRPF.Text = "15%";
                        pIRPF = 0.15;
                    }
                    if (verifySalBruto > 2512.08)
                    {
                        mskbxAliqIRPF.Text = "27,5%";
                        pIRPF = 0.275;
                    }
                    if (verifySalBruto <= 435.52)
                    {
                        salFamilia = 22.33 * verifyNumFilhos;
                    }
                    if (verifySalBruto >= 435.53 && verifySalBruto <= 654.61)
                    {
                        salFamilia = 15.74 * verifyNumFilhos;
                    }
                    if (verifySalBruto > 654.61)
                    {
                        salFamilia = 0;
                    }
                    valINSS = valINSS + (verifySalBruto * pINSS);
                    mskbxDescINSS.Text = valINSS.ToString("N2");
                    valIRPF = valIRPF + (verifySalBruto * pIRPF);
                    mskbxDescIRPF.Text = valIRPF.ToString("N2");
                    mskbxSalFamilia.Text = salFamilia.ToString("N2");
                    salLiquido = verifySalBruto - valINSS - valIRPF + salFamilia;
                    mskbxSalLiquido.Text = salLiquido.ToString("N2");

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Dados inválidos. "+ exception.Message);
            }

        }
    }
}
