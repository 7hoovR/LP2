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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int c=0;
            for (var x=0; x<rchtxtTexto.Text.Length; x++)
            {
                if (Char.IsNumber(rchtxtTexto.Text[x]))
                {
                    c ++;
                }
            }
            MessageBox.Show("Caracteres numéricos: " +c);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x < rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[x]))
                {
                    MessageBox.Show("Primeiro caracter branco: " + (x+1));
                    break;
                }
                x++;
            }
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            int x = 0;
            foreach (char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))
                {
                    x++;
                }
            }
            MessageBox.Show("Caracteres Alfabeticos: " + x);
        }
    }
}
