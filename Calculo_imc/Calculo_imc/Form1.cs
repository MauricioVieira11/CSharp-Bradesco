using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            txtImc.Text = imc.ToString("F2");

            if (imc < 18.49)
                MessageBox.Show("Você está abaixo do peso", "Calculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("PEso dentro da normalidade", "Cálculo de IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("Acima do peso", "Cálculo de IMC", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("Voce está com obesidade grau I", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("Você está com obesidade grau II", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("vocÊ está com obesidade grau III", "Cálculo de IMC",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtImc.Text = "";

        }
    }
}
