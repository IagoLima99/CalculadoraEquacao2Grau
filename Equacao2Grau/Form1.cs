using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equacao2Grau
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Equacao2 eq2 = new Equacao2();
            eq2.A = Convert.ToInt32(txtA.Text);
            eq2.B = Convert.ToInt32(txtB.Text);
            eq2.C = Convert.ToInt32(txtC.Text);
            eq2.Calcular();

            if (eq2.Solucao == 0)
                MessageBox.Show("Não há solução real");
            else if (eq2.Solucao == 1)
                MessageBox.Show("X1 e X2 = " + eq2.X1.ToString());
            else
                MessageBox.Show("X1 = " + eq2.X1.ToString() + "\nX2 = " + eq2.X2.ToString());
                
        }
    }
}
