﻿using System;
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
    public partial class Form1 : Form
    {
        Pergunta[] perguntas = new Pergunta[24];

        Node<int> atual = null;
        int chance = 0;
        int n_per = 1;
        int step_barra;

        //fonte
        PrivateFontCollection pfc = new PrivateFontCollection();

        WindowsMediaPlayer effect_g_player;
        public Form1(WMPLib.WindowsMediaPlayer player)
        {
            InitializeComponent();
            pfc.AddFontFile("Resources/fonte.ttf");
            labelPergunta.Font = new System.Drawing.Font(pfc.Families[0], 36, System.Drawing.FontStyle.Regular);
            labelNumero.Font = new System.Drawing.Font(pfc.Families[0], 18, System.Drawing.FontStyle.Bold);
            labelVoltar.Font = new System.Drawing.Font(pfc.Families[0], 14, System.Drawing.FontStyle.Regular);
            labelBarra.Font = new System.Drawing.Font(pfc.Families[0], 14, System.Drawing.FontStyle.Regular);
            labelBarraValue.Font = new System.Drawing.Font(pfc.Families[0], 16, System.Drawing.FontStyle.Regular);
            this.effect_g_player = player;
            backgroundWorker1.RunWorkerAsync();

           
        }

        void updateBarra(int val)
        {
            if (val < chance)
            {
                if (val < 0)
                    val = 0;
                step_barra = -1;
            }
            else if (val > chance)
            {
                if (val > 100)
                    val = 100;
                step_barra = 1;
            }
            chance = val;
            timerUpdateBarra.Start();
        }

        void updateForm()
        {
            if (atual != null)
            {
                if(chance==0)
                {
                    oculosCair();
                    perguntas[23].valor_n = 0;
                    perguntas[23].valor_s = 30;
                    perguntas[23].texto = "Você tem certeza que deseja continuar?";
                    Node<int> sefudeu = new Node<int>(23);
                    sefudeu.nao = null;
                    sefudeu.sim = atual;
                    atual = sefudeu;
                }
                    labelPergunta.Text = perguntas[atual.info].texto;
                    labelNumero.Text = "Pergunta " + n_per++.ToString();
               
            }
            else
            {
                labelPergunta.Font = new System.Drawing.Font(pfc.Families[0], 48, System.Drawing.FontStyle.Regular);
                labelPergunta.Text = "Sua chance é de "+chance.ToString()+"%";
                if(chance>50)
                {
                    effect_g_player.URL = "Resources/applause.mp3";
                    effect_g_player.controls.play();
                }
                else
                {
                    effect_g_player.URL = "Resources/boo.mp3";
                    effect_g_player.controls.play();
                }
                labelVoltar.Visible = true;
                buttonSim.Enabled = false;
                buttonNao.Enabled = false;
                buttonNao.Visible = false;
                buttonSim.Visible = false;
            }
        }

        private void buttonNao_Click(object sender, EventArgs e)
        {
            effect_g_player.controls.play();
            updateBarra(chance + perguntas[atual.info].valor_n);
            atual = atual.nao;
            updateForm();
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            effect_g_player.controls.play();
            updateBarra(chance + perguntas[atual.info].valor_s);
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
            effect_g_player.URL = "Resources/click.mp3";
            effect_g_player.controls.play();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            perguntas[0].texto = "Você é bonito(a)?";
            perguntas[0].valor_s = 10;
            perguntas[0].valor_n = -20;
            perguntas[1].texto = "Ela é bonita(o)?";
            perguntas[1].valor_s = -10;
            perguntas[1].valor_n = 10;
            perguntas[2].texto = "Você faz computação?";
            perguntas[2].valor_s = -10;
            perguntas[2].valor_n = 10;
            perguntas[3].texto = "Você faz o mesmo curso que ela/ele?";
            perguntas[3].valor_s = 20;
            perguntas[3].valor_n = -5;
            perguntas[4].texto = "Vocês se conhecem?";
            perguntas[4].valor_s = 5;
            perguntas[4].valor_n = -5;
            perguntas[5].texto = "Ela/ele tem namorado(a)?";
            perguntas[5].valor_s = -40;
            perguntas[5].valor_n = 5;
            perguntas[6].texto = "Você é muito amigo(a) dessa pessoa?";
            perguntas[6].valor_s = 10;
            perguntas[6].valor_n = 0;
            perguntas[7].texto = "Você acha que está na 'friendzone'?";
            perguntas[7].valor_s = -50;
            perguntas[7].valor_n = 10;
            perguntas[8].texto = "Vocês já se beijaram alguma vez?";
            perguntas[8].valor_s = 20;
            perguntas[8].valor_n = 0;
            perguntas[9].texto = "Você tem vergonha de ir falar com essa pessoa?";
            perguntas[9].valor_s = -20;
            perguntas[9].valor_s = 15;
            perguntas[10].texto = "Por acaso ela/ele é sua/seu ex?";
            perguntas[10].valor_s = 0;
            perguntas[10].valor_n = 0;
            perguntas[11].texto = "Ela/Ele te odeia?";
            perguntas[11].valor_s = -100;
            perguntas[11].valor_n = 10;
            perguntas[12].texto = "Vocês têm interesses em comum?";
            perguntas[12].valor_s = 20;
            perguntas[12].valor_n = -20;
            perguntas[13].texto = "Ela/Ela gosta de outra pessoa?";
            perguntas[13].valor_s = -20;
            perguntas[13].valor_n = 10;
            perguntas[14].texto = "Ela/Ele já te disse que não quer ficar com você?";
            perguntas[14].valor_s = -50;
            perguntas[14].valor_n = 10;
            perguntas[15].texto = "Vocês moram em cidades diferentes?";
            perguntas[15].valor_s = -30;
            perguntas[15].valor_n = 5;
            perguntas[16].texto = "Vocês moram em estados diferentes?";
            perguntas[16].valor_s = -30;
            perguntas[16].valor_n = 5;
            perguntas[17].texto = "Ela/Ele te despreza?";
            perguntas[17].valor_s = -50;
            perguntas[17].valor_n = 10;
            perguntas[18].texto = "A família dessa pessoa gosta de você?";
            perguntas[18].valor_s = 20;
            perguntas[18].valor_n = -10;
            perguntas[19].texto = "As amigas dessa pessoa gostam de você?";
            perguntas[19].valor_s = 20;
            perguntas[19].valor_n = -10;
            perguntas[20].texto = "Alguma amiga(o) dessa pessoa quer ficar com você?";
            perguntas[20].valor_s = -40;
            perguntas[20].valor_n = 0;
            perguntas[21].texto = "Você vê essa pessoa frequentemente?";
            perguntas[21].valor_s = 15;
            perguntas[21].valor_n = -20;
            perguntas[22].texto = "Vocês continuaram conversando depois disso?";
            perguntas[22].valor_s = 30;
            perguntas[22].valor_n = -20;

            Arvore arv = new Arvore();
            atual = arv.raiz();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelPergunta.Text = perguntas[atual.info].texto;
            labelNumero.Text = "Pergunta " + n_per++.ToString();
            updateBarra(50);
            
            buttonSim.Enabled = true;
            buttonNao.Enabled = true;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            oculosCair();
        }

        void oculosCair()
        {
            panel1.Location = new Point(panel1.Location.X, 70);
            panel1.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.oculos2;
            timerOculos.Start();
        }

        private void timerOculos_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.Y < 112)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 2);
            }
            else
                timerOculos.Stop();
        }
    }
}
