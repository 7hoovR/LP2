using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_02___Prática
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int pos1 = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (pos1>=0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, pos1) +
                    txtPalavra2.Text.Substring(pos1 + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - pos1 - txtPalavra1.Text.Length);
                pos1 = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text;
            
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, null);
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text;
            char[] arr = palavra1.ToCharArray();

            Array.Reverse(arr);
            palavra1 = null;
            foreach (char c in arr)
            {
                palavra1 = palavra1 + c.ToString();
            }
            MessageBox.Show(palavra1); // ou return new string(arr); após reverse
        }
    }
}
