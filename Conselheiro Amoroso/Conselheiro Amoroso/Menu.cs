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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            Form jogo = new Form1();
            jogo.StartPosition = FormStartPosition.Manual;
            jogo.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;
            if (jogo.ShowDialog() == DialogResult.OK)
            {
                this.Location = new Point(jogo.Location.X, jogo.Location.Y);
                this.Visible = true;
            }
            else
                Application.Exit();
            
        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            Form ajuda = new Ajuda();
            ajuda.ShowDialog();
        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            Form sobre = new Sobre();
            sobre.ShowDialog();
        }
    }
}
