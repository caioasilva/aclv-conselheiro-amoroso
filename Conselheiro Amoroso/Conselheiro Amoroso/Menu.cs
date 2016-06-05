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
        public WMPLib.WindowsMediaPlayer music_player = new WMPLib.WindowsMediaPlayer();
        public WMPLib.WindowsMediaPlayer effect_player = new WMPLib.WindowsMediaPlayer();
        public Menu()
        {
            InitializeComponent();
            effect_player.settings.autoStart = true;
            music_player.settings.autoStart = false;
            music_player.URL = "Resources/main_music.mp3";
            music_player.settings.setMode("loop", true);
            EnableDoubleBuffering();

        }

        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }
        private void buttonMain_Click(object sender, EventArgs e)
        {
            effect_player.URL = "Resources/click.mp3";
            music_player.controls.play();
            Form jogo = new Form1(effect_player);
            jogo.StartPosition = FormStartPosition.Manual;
            jogo.Location = new Point(this.Location.X, this.Location.Y);
            this.Visible = false;

            if (jogo.ShowDialog() == DialogResult.OK)
            {
                this.Location = new Point(jogo.Location.X, jogo.Location.Y);
                this.Visible = true;
                music_player.controls.stop();
                jogo.Dispose();
            }
            else
                Application.Exit();
            
        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {
            effect_player.URL = "Resources/click.mp3";
            Form ajuda = new Ajuda();
            ajuda.ShowDialog();
        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {
            effect_player.URL = "Resources/click.mp3";
            Form sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.Y < 254)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 2);
                panel1.Visible = true;
            }
            else
                timer1.Stop();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Location = new Point(panel1.Location.X, 127);
            timer1.Start();
            effect_player.URL = "Resources/tdfw.mp3";
        }

    }
}
