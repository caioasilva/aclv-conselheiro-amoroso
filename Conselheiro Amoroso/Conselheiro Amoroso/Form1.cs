using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

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
        int n_per = 1;
        int step_barra;

        //fonte
        PrivateFontCollection pfc = new PrivateFontCollection();
        WMPLib.WindowsMediaPlayer music_player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer effect_player = new WMPLib.WindowsMediaPlayer();
        

        public Form1()
        {
            InitializeComponent();
            pfc.AddFontFile("fonte.ttf");
            labelPergunta.Font = new System.Drawing.Font(pfc.Families[0], 30, System.Drawing.FontStyle.Regular);
            labelNumero.Font = new System.Drawing.Font(pfc.Families[0], 18, System.Drawing.FontStyle.Bold);
            labelVoltar.Font = new System.Drawing.Font(pfc.Families[0], 14, System.Drawing.FontStyle.Regular);
            labelBarra.Font = new System.Drawing.Font(pfc.Families[0], 14, System.Drawing.FontStyle.Regular);
            labelBarraValue.Font = new System.Drawing.Font(pfc.Families[0], 16, System.Drawing.FontStyle.Regular);
            music_player.URL = "main_music.mp3";
            music_player.settings.setMode("Loop", true);

            perguntas[0].texto = "Voce é bonito?";
            perguntas[0].valor = 10;
            perguntas[1].texto = "Ela é bonita?";
            perguntas[1].valor = -15;
            perguntas[2].texto = "Você faz computação?";
            perguntas[2].valor = -10;
            perguntas[3].texto = "Ela faz computação também?";
            perguntas[3].valor = 20;
            perguntas[4].texto = "Vocês se conhecem?";
            perguntas[4].valor = 5;

            atual = new Node<int>(2);
                atual.sim = new Node<int>(3);
                    atual.sim.sim = new Node<int>(0);
                        atual.sim.sim.sim = new Node<int>(4);
                        atual.sim.sim.nao = new Node<int>(1);
                    atual.sim.nao = new Node<int>(0);
                        atual.sim.nao.sim = new Node<int>(1);
                        atual.sim.nao.nao = new Node<int>(1);
                atual.nao = new Node<int>(0);
                    atual.nao.sim = new Node<int>(1);
                    atual.nao.nao = new Node<int>(1);


            labelPergunta.Text = perguntas[atual.info].texto;
            labelNumero.Text = "Pergunta " + n_per++.ToString();
            progressBar1.Value = chance;


            music_player.controls.play();
        }

        
        void updateBarra(int val)
        {
            if (val < chance)
            {
                step_barra = -1;
            }
            else if (val > chance)
            {
                step_barra = 1;
            }
            chance = val;
            timerUpdateBarra.Start();
        }

        void updateForm()
        {
            if (atual != null)
            {
                labelPergunta.Text = perguntas[atual.info].texto;
                labelNumero.Text = "Pergunta " + n_per++.ToString();
            }
            else
            {
                labelPergunta.Text = "Sua chance é de "+chance.ToString()+"%";
                buttonSim.Enabled = false;
                buttonNao.Enabled = false;
                buttonNao.Visible = false;
                buttonSim.Visible = false;
            }
        }

        private void buttonNao_Click(object sender, EventArgs e)
        {
            updateBarra(chance - perguntas[atual.info].valor);
            atual = atual.nao;
            updateForm();
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            updateBarra(chance + perguntas[atual.info].valor);
            atual = atual.sim;
            updateForm();
        }

        private void buttonSim_MouseHover(object sender, EventArgs e)
        {
            
            buttonSim.BackgroundImage= (Properties.Resources.bt_sim_hover);
        }

        private void buttonSim_MouseLeave(object sender, EventArgs e)
        {
            buttonSim.BackgroundImage = (Properties.Resources.bt_sim);
        }

        private void buttonSim_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSim.BackgroundImage = (Properties.Resources.bt_sim_down);
        }

        private void buttonSim_MouseUp(object sender, MouseEventArgs e)
        {
            buttonSim.BackgroundImage = (Properties.Resources.bt_sim_hover);
        }

        private void buttonNao_MouseDown(object sender, MouseEventArgs e)
        {
            buttonNao.BackgroundImage = (Properties.Resources.bt_nao_down);
        }

        private void buttonNao_MouseHover(object sender, EventArgs e)
        {
            buttonNao.BackgroundImage = (Properties.Resources.bt_nao_hover);
        }

        private void buttonNao_MouseLeave(object sender, EventArgs e)
        {
            buttonNao.BackgroundImage = (Properties.Resources.bt_nao);
        }

        private void buttonNao_MouseUp(object sender, MouseEventArgs e)
        {
            buttonNao.BackgroundImage = (Properties.Resources.bt_nao_hover);
        }

        private void buttonVoltar_MouseDown(object sender, MouseEventArgs e)
        {
            buttonVoltar.BackgroundImage = (Properties.Resources.back_down);
        }

        private void buttonVoltar_MouseHover(object sender, EventArgs e)
        {
            buttonVoltar.BackgroundImage = (Properties.Resources.back_hover);
            labelVoltar.Visible = true;
        }

        private void buttonVoltar_MouseLeave(object sender, EventArgs e)
        {
            buttonVoltar.BackgroundImage = (Properties.Resources.back);
            labelVoltar.Visible = false;
        }

        private void buttonVoltar_MouseUp(object sender, MouseEventArgs e)
        {
            buttonVoltar.BackgroundImage = (Properties.Resources.back_hover);
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void timerUpdateBarra_Tick(object sender, EventArgs e)
        {
            if ((step_barra > 0 && progressBar1.Value < chance) || (step_barra < 0 && progressBar1.Value > chance))
            {
                progressBar1.Value += step_barra;
                labelBarraValue.Text = progressBar1.Value.ToString() + "%";
            }
            else {
                timerUpdateBarra.Stop();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
