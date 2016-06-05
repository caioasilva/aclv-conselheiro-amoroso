using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace Conselheiro_Amoroso
{
    public partial class Menu : Form
    {
        WMPLib.WindowsMediaPlayer effect_player = new WMPLib.WindowsMediaPlayer();
        public Menu()
        {
            InitializeComponent();
            effect_player.settings.autoStart = false;
            effect_player.URL = "Resources/click.mp3";
            
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            effect_player.controls.play();
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
            effect_player.controls.play();
            Form ajuda = new Ajuda();
            ajuda.ShowDialog();
        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            effect_player.controls.play();
            Form sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.Y < 255)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 2);
            }
            else
                timer1.Stop();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X, 127);
            timer1.Start();
        }
    }
}
