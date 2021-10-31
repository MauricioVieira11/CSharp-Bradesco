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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboOpcao.Text)
            {
                case "1 ou 2":
                    cboOpcao.Text = "O dia do seu rodízio é segunda feira!";
                    break;
                case "3 ou 4":
                    cboOpcao.Text = "O dia do seu rodízio é Terça-feira!";
                    break;
                case "5 ou 6":
                    cboOpcao.Text = "O dia do seu rodízio é Quarta-feira!";
                    break;
                case "7 ou 8":
                    cboOpcao.Text = "O dia do seu rodízio é Quinta-feira!";
                    break;
                case "9 ou 0":
                    cboOpcao.Text = "O dia do seu rodízio é Sexta-feira!";
                    break;





            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();

            this.Visible = false;

        }

        private void cboOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
