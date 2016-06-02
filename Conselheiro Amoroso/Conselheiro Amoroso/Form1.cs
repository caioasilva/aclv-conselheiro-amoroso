using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Conselheiro_Amoroso
{
    public struct Pergunta
    {
        public string texto;
        public int valor;
    }

    public partial class Form1 : Form
    {
        Pergunta[] perguntas = new Pergunta[100];

        Node<int> atual = null;
        int chance = 50;
        public Form1()
        {
            InitializeComponent();
       
            perguntas[0].texto = "Voce é bonito?";
            perguntas[0].valor = 10;
            perguntas[1].texto = "Ela é bonita?";
            perguntas[1].valor = -15;
            perguntas[2].texto = "Voce faz computação?";
            perguntas[2].valor = -10;
            perguntas[3].texto = "Ela faz computação também?";
            perguntas[3].valor = 20;
            perguntas[4].texto = "Vocês se conhecem?";
            perguntas[4].valor = 5;

            atual = new Node<int>(2);
                atual.esq = new Node<int>(3);
                    atual.esq.esq = new Node<int>(0);
                        atual.esq.esq.esq = new Node<int>(4);
                        atual.esq.esq.dir = new Node<int>(1);
                    atual.esq.dir = new Node<int>(0);
                        atual.esq.dir.esq = new Node<int>(1);
                        atual.esq.dir.dir = new Node<int>(1);
                atual.dir = new Node<int>(0);
                    atual.dir.esq = new Node<int>(1);
                    atual.dir.dir = new Node<int>(1);


            labelPergunta.Text = perguntas[atual.info].texto;
            progressBar1.Value = chance;
        }

        void updateForm()
        {
            if (atual != null)
            {
                labelPergunta.Text = perguntas[atual.info].texto;
                progressBar1.Value = chance;
            }
            else
            {
                labelPergunta.Text = "FIM";
                progressBar1.Value = chance;
            }
        }


        private void buttonNao_Click(object sender, EventArgs e)
        {
            chance -= perguntas[atual.info].valor;
            atual = atual.dir;
            updateForm();
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            chance += perguntas[atual.info].valor;
            atual = atual.esq;
            updateForm();
        }
    }
}
