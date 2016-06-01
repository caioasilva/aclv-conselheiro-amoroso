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
        public Form1()
        {
            InitializeComponent();
            Node<string> R = new Node<string>("Você é bonito?");
            R.esq = new Node<string>("Ela é feia?");
            R.dir = new Node<string>("Ela é bonita?");
            atual = R;
            labelPergunta.Text = atual.info;
        }


        private void buttonNao_Click(object sender, EventArgs e)
        {
            atual = atual.dir;
            labelPergunta.Text = atual.info;
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            atual = atual.esq;
            labelPergunta.Text = atual.info;
        }
    }
}
