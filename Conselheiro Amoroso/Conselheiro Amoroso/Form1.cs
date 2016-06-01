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
    public partial class Form1 : Form
    {
        Node<string> atual = null;
        int chance = 50;
        public Form1()
        {
            InitializeComponent();
            Node<string> R = new Node<string>("Você é bonito?",20);
            R.esq = new Node<string>("Ela é feia?",10);
                R.esq.esq = new Node<string>("Ela faz computação?", 30);
            
            R.dir = new Node<string>("Ela é bonita?",-30);

            atual = R;
            labelPergunta.Text = atual.info;
            progressBar1.Value = chance;
        }


        private void buttonNao_Click(object sender, EventArgs e)
        {
            chance -= atual.valor;
            atual = atual.dir;
            labelPergunta.Text = atual.info;
            progressBar1.Value = chance;
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            chance += atual.valor;
            atual = atual.esq;
            labelPergunta.Text = atual.info;
            progressBar1.Value = chance;
        }
    }
}
