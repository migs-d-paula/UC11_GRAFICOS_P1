using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_GRAFICOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelIMC.Text = "";
            labelLOGIN.Text = "";
        }

        private void buttonCALCULAR_Click(object sender, EventArgs e)
        {
            //CADASTRANDO OS NUMEROS

            double numero1, numero2, senha, resultado;

            numero1 = double.Parse(textBoxNUMERO.Text.Replace(".", ","));
            numero2 = double.Parse(textBoxNUMERO2.Text.Replace(".", ","));
            resultado = numero1 + numero2;

            //MOSTRANDO O QUE É DESEJADO

            MessageBox.Show("O RESULTADO É: " + resultado);
        }

        public string nome, password;
        int vida = 3;

        private void buttonCADASTRAR_Click_1(object sender, EventArgs e)
        {
            //CADASTRANDO OS NOMES

            nome = textBoxNOME.Text;
            password = textBoxPASSWORD.Text;

            //MOSTRANDO O QUE É DESEJADO

            MessageBox.Show(nome  + "\n" + password);
        }

        private void buttonIMC_Click(object sender, EventArgs e)
        {
            //CADASTRANDO AS VARIAVEIS

            double altura, peso, imc;


            altura = double.Parse(textBoxALTURA.Text.Replace(".", ","));
            peso = double.Parse(textBoxPESO.Text);

            imc = peso / (altura * altura);
            string situacao;

            if (imc < 18.5)
            {
                situacao = ("Você está ABAIXO DO PESO");
                labelIMC.Text = (imc + "\n" + situacao);
            }
            else {
                if (imc < 24.9)
                {
                    situacao = ("Você está NO PESO IDEAL");
                    labelIMC.Text = (imc + "\n" + situacao);
                }
                else
                {
                    if (imc < 29.9)
                    {
                        situacao = ("Você está COM PRÉ-OBESIDADE");
                        labelIMC.Text = (imc + "\n" + situacao);
                    }
                    else
                    {
                        if (imc < 34.9)
                        {
                            situacao = ("Você está COM OBESIDADE GRAU 1");
                            labelIMC.Text = (imc + "\n" + situacao);
                        }
                        else
                        {
                            if (imc < 39.9)
                            {
                                situacao = ("Você está COM OBESIDADE GRAU 2");
                                labelIMC.Text = (imc + "\n" + situacao);
                            }
                            else
                            {
                                if (imc > 40)
                                {
                                    situacao = ("Você está COM OBESIDADE GRAU 3");
                                    labelIMC.Text = ("IMC = " + imc + "\n" + situacao);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxUSUARIO.Text = "";
            textBoxSENHA.Text = "";
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUSUARIO.Text;
            string senha = textBoxSENHA.Text;

            if (usuario != nome || senha != password)
            {
                vida--;

                labelLOGIN.Text = ("USUARIO OU SENHA INCORRETOS\nAINDA RESTAM " + vida + " TENTATIVAS");
            }
            if (vida == 0)
            {
                labelLOGIN.Text = ("SUAS TENTATIVAS ACABARAM");
                textBoxUSUARIO.Enabled = false;
                textBoxSENHA.Enabled = false;
            }
            if (usuario == nome && senha == password)
            {
                MessageBox.Show("você entrou");
            }
 
        }         
    }
}
