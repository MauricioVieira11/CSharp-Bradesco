using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1];

            System.Array.Sort(vetor);
            for (int index = 0; index < 4; index++)
                MessageBox.Show(vetor[index].ToString(),
                    "Array");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domingo";
            semana[1] = "Segunda-feira";
            semana[2] = "Terça-feira";
            semana[3] = "Quarta-feira";
            semana[4] = "Quinta-feira";
            semana[5] = "Sexta-feira";
            semana[6] = "Sábado";

            string valor = semana[1];
            for (int index = 0; index < 7; index++)
                MessageBox.Show(semana[index].ToString(),
                    "Array");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4];
            notas[0, 0] = 8.0;
            notas[0, 1] = 7.5;
            notas[0, 2] = 9.0;
            notas[0, 3] = 8.5;
            notas[1, 0] = 9.5;
            notas[1, 1] = 8.5;
            notas[1, 2] = 8.0;
            notas[1, 3] = 9.0;

            MessageBox.Show(notas[0, 1].ToString(), "Array");
            MessageBox.Show(notas[0, 2].ToString(), "Array");

        }
    }
}
