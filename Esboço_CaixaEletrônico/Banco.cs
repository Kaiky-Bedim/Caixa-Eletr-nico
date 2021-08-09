using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Esboço_CaixaEletrônico
{
    public partial class Banco : Form
    {
        double saldo = 5000;

        public Banco()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Banco_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variável x representa o valor a ser sacado
            double x = double.Parse(textBox1.Text);

            if ((saldo - x) < 0)
            {
                MessageBox.Show("Não é possível sacar, seu saldo é muito baixo");
            }
            else
            {

                //Trecho que determina a Qtd de notas de cem
                int qtdcem = (int)x / 100;
                double resto = x % 100;

                //Trecho que determina a Qtd de notas de cinquenta
                int qtdcinquenta = (int)resto / 50;
                resto = resto % 50;

                //Trecho que determina a Qtd de notas de vinte
                int qtdvinte = (int)resto / 20;
                resto = resto % 20;

                //Trecho que determina a Qtd de notas de dez
                int qtddez = (int)resto / 10;
                resto = resto % 10;

                //É descontado o valor do saque 
                saldo -= qtdcem*100 + qtdcinquenta*50 + qtdvinte*20 + qtddez*10;
                label2.Text = "Seu saldo é " + saldo;

                //Labels recebem as quantidades de notas para o saque
                label4.Text = "Qtd de notas de cem: " + qtdcem;
                label5.Text = "Qtd de notas de cinquenta: " + qtdcinquenta;
                label6.Text = "Qtd de notas de vinte: " + qtdvinte;
                label7.Text = "Qtd de notas de dez: " + qtddez;
                textBox1.Clear();
            }
        }
    }
}
