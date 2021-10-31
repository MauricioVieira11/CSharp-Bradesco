using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Domingo é o primeiro dia da semana","Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Segunda é o 2º dia da semana!","Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Terça é o 3º dia da semana", "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Quarta é o 4º dia da semana", "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Quinta é o 5º dia da semana", "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Terça é o 6º dia da semana", "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;
                case "Sábado":
                    MessageBox.Show("Sábado é o 7º dia da semana", "Mensagem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();

            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
