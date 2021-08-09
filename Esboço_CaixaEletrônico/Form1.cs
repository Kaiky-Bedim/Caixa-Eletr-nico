using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Trabalhei com os sistemas de Threads

namespace Esboço_CaixaEletrônico
{
    public partial class Form1 : Form
    {
        Thread NewT;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dados de Acesso pré-determinados, não há conexão com BD's
            string email = textBox1.Text;
            if(email == "kaiky.bedim@gmail.com" && textBox2.Text == "1234")
            {

                //Trecho responsável por fechar o primeiro Forms e abrir o segundo Forms
                this.Close();
                NewT = new Thread(NovoForm);
                NewT.SetApartmentState(ApartmentState.STA);
                NewT.Start();
            }
            else{
                MessageBox.Show("Login ou Senha errados");
            }


        }

        private void NovoForm(object obj)
        {
            Application.Run(new Banco());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
