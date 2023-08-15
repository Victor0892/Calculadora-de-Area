using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeÁrea
{
    public partial class FrmCalculadoraDeÁrea : Form
    {
        public FrmCalculadoraDeÁrea()
        {
            InitializeComponent();

        }

        private void FrmCalculadoraDeÁrea_Load(object sender, EventArgs e)
        {

        }

        private bool ValidaValores(out decimal valor1, out decimal valor2)
        {
            valor1 = 0;
            valor2 = 0;

            if (TxtValor1.Text.Trim() == "")
            {
                MessageBox.Show("Informe um valor numérico para o campo Base.", ProductName, MessageBoxButtons.OK);
                TxtValor1.Focus();
                return false;
            }
            if (TxtValor2.Text.Trim() == "")
            {
                MessageBox.Show("Informe um valor numérico para o campo Altura.", ProductName, MessageBoxButtons.OK);
                TxtValor2.Focus();
                return false;
            }
            if (decimal.TryParse(TxtValor1.Text, out valor1) == false)
            {
                MessageBox.Show("Informe um valor numérico para o campo Base.", ProductName, MessageBoxButtons.OK);
                TxtValor1.Focus();
                return false;
            }
            if (decimal.TryParse(TxtValor2.Text, out valor2) == false)
            {
                MessageBox.Show("Informe um valor numérico para o campo Altura.", ProductName, MessageBoxButtons.OK);
                TxtValor2.Focus();
                return false;
            }

            return true;


        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2;
            if (ValidaValores(out valor1, out valor2) == true)
            {
                LblDisplay.Text = (valor1 * valor2).ToString();
            }
        }

        private bool ValidaValoresTRI(out decimal valor3, out decimal valor4)
        {
            valor3 = 0;
            valor4 = 0;

            if (TxtValor3.Text.Trim() == "")
            {
                MessageBox.Show("Informe um valor numérico para o campo Base.", ProductName, MessageBoxButtons.OK);
                TxtValor3.Focus();
                return false;
            }
            if (TxtValor4.Text.Trim() == "")
            {
                MessageBox.Show("Informe um valor numérico para o campo Altura.", ProductName, MessageBoxButtons.OK);
                TxtValor4.Focus();
                return false;
            }
            if (decimal.TryParse(TxtValor3.Text, out valor3) == false)
            {
                MessageBox.Show("Informe um valor numérico para o campo Base.", ProductName, MessageBoxButtons.OK);
                TxtValor3.Focus();
                return false;
            }
            if (decimal.TryParse(TxtValor4.Text, out valor4) == false)
            {
                MessageBox.Show("Informe um valor numérico para o campo Altura.", ProductName, MessageBoxButtons.OK);
                TxtValor4.Focus();
                return false;
            }

            return true;
        }

        private void BtnCalcular2_Click(object sender, EventArgs e)
        {
            decimal valor3, valor4;
            if (ValidaValoresTRI(out valor3, out valor4) == true)
            {
                LblDisplay.Text = ((valor3 * valor4) / 2).ToString();
            }
        }

        private bool Double(out double valor5, out double valor6)
        {
            valor5 = 0;
            valor6 = 0;

            if (TxtValor5.Text.Trim() == "")
            {
                MessageBox.Show("Informe um valor numérico para o campo Pi.", ProductName, MessageBoxButtons.OK);
                TxtValor5.Focus();
                return false;
            }
            if (TxtValor6.Text.Trim() == "")
            {
                MessageBox.Show("Informe um valor numérico para o campo Raio.", ProductName, MessageBoxButtons.OK);
                TxtValor6.Focus();
                return false;
            }
            if (double.TryParse(TxtValor5.Text, out valor5) == false)
            {
                MessageBox.Show("Informe um valor numérico para o campo Pi.", ProductName, MessageBoxButtons.OK);
                TxtValor5.Focus();
                return false;
            }
            if (double.TryParse(TxtValor6.Text, out valor6) == false)
            {
                MessageBox.Show("Informe um valor numérico para o campo Raio.", ProductName, MessageBoxButtons.OK);
                TxtValor6.Focus();
                return false;
            }

            return true;


        }

        private void BtnCalcular3_Click(object sender, EventArgs e)
        {
            double valor5, valor6;
            if (Double(out valor5, out valor6) == true)
            {
                LblDisplay.Text = (valor5 * Math.Pow(valor6, 2)).ToString();
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = "";
            TxtValor1.Text = "";
            TxtValor2.Text = "";
            TxtValor3.Text = "";
            TxtValor4.Text = "";
            TxtValor5.Text = "";
            TxtValor6.Text = "";
        }
    }
}
