using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_media
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, num3,num4, media;
            num1 = Convert.ToDouble(txtNota1.Text);
            num2 = Convert.ToDouble(txtNota2.Text);
            num3 = Convert.ToDouble(txtNota3.Text);
            num4 = Convert.ToDouble(txtNota4.Text);
            media = (num1 + num2 + num3 + num4) / 4;
            txtMedia.Text = media.ToString();

            if (media >= 7)
            {
                txtSituacao.Text = "Aprovado!";
            }
            else if (media >= 5 && media <= 6)
            {
                txtSituacao.Text = "Recuperação!";
            }
            else
            {
                txtSituacao.Text = "Reprovado!";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtMedia.Text = "";
            txtSituacao.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
