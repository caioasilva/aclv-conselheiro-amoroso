using System.Drawing.Text;


namespace Conselheiro_Amoroso
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonNao = new System.Windows.Forms.Button();
            this.labelNumero = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelPergunta = new System.Windows.Forms.Label();
            this.labelVoltar = new System.Windows.Forms.Label();
            this.labelBarra = new System.Windows.Forms.Label();
            this.timerUpdateBarra = new System.Windows.Forms.Timer(this.components);
            this.labelBarraValue = new System.Windows.Forms.Label();
            this.progressBar1 = new Conselheiro_Amoroso.RedProgressBar();
            this.SuspendLayout();
            // 
            // buttonSim
            // 
            this.buttonSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSim.BackgroundImage")));
            this.buttonSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSim.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSim.FlatAppearance.BorderSize = 0;
            this.buttonSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSim.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSim.Location = new System.Drawing.Point(108, 501);
            this.buttonSim.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(248, 88);
            this.buttonSim.TabIndex = 9;
            this.buttonSim.UseVisualStyleBackColor = true;
            this.buttonSim.Click += new System.EventHandler(this.buttonSim_Click);
            this.buttonSim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSim_MouseDown);
            this.buttonSim.MouseLeave += new System.EventHandler(this.buttonSim_MouseLeave);
            this.buttonSim.MouseHover += new System.EventHandler(this.buttonSim_MouseHover);
            this.buttonSim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSim_MouseUp);
            // 
            // buttonNao
            // 
            this.buttonNao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNao.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.bt_nao;
            this.buttonNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNao.FlatAppearance.BorderSize = 0;
            this.buttonNao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNao.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonNao.Location = new System.Drawing.Point(437, 501);
            this.buttonNao.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(248, 88);
            this.buttonNao.TabIndex = 8;
            this.buttonNao.UseVisualStyleBackColor = true;
            this.buttonNao.Click += new System.EventHandler(this.buttonNao_Click);
            this.buttonNao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNao_MouseDown);
            this.buttonNao.MouseLeave += new System.EventHandler(this.buttonNao_MouseLeave);
            this.buttonNao.MouseHover += new System.EventHandler(this.buttonNao_MouseHover);
            this.buttonNao.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonNao_MouseUp);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.BackColor = System.Drawing.Color.Transparent;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(36, 333);
            this.labelNumero.MinimumSize = new System.Drawing.Size(150, 0);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(150, 29);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "Pergunta X";
            this.labelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.back;
            this.buttonVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.Location = new System.Drawing.Point(9, 9);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(56, 57);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            this.buttonVoltar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVoltar_MouseDown);
            this.buttonVoltar.MouseLeave += new System.EventHandler(this.buttonVoltar_MouseLeave);
            this.buttonVoltar.MouseHover += new System.EventHandler(this.buttonVoltar_MouseHover);
            this.buttonVoltar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonVoltar_MouseUp);
            // 
            // labelPergunta
            // 
            this.labelPergunta.AutoEllipsis = true;
            this.labelPergunta.AutoSize = true;
            this.labelPergunta.BackColor = System.Drawing.Color.Transparent;
            this.labelPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPergunta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPergunta.Location = new System.Drawing.Point(54, 375);
            this.labelPergunta.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelPergunta.MinimumSize = new System.Drawing.Size(690, 100);
            this.labelPergunta.Name = "labelPergunta";
            this.labelPergunta.Size = new System.Drawing.Size(690, 100);
            this.labelPergunta.TabIndex = 5;
            this.labelPergunta.Text = "Texto da Pergunta ";
            this.labelPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVoltar
            // 
            this.labelVoltar.AutoSize = true;
            this.labelVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltar.ForeColor = System.Drawing.Color.DarkRed;
            this.labelVoltar.Location = new System.Drawing.Point(12, 61);
            this.labelVoltar.Name = "labelVoltar";
            this.labelVoltar.Size = new System.Drawing.Size(49, 16);
            this.labelVoltar.TabIndex = 10;
            this.labelVoltar.Text = "Voltar";
            this.labelVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVoltar.Visible = false;
            // 
            // labelBarra
            // 
            this.labelBarra.AutoSize = true;
            this.labelBarra.BackColor = System.Drawing.Color.Transparent;
            this.labelBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBarra.Location = new System.Drawing.Point(374, 3);
            this.labelBarra.Name = "labelBarra";
            this.labelBarra.Size = new System.Drawing.Size(132, 24);
            this.labelBarra.TabIndex = 11;
            this.labelBarra.Text = "Barra do Amor";
            // 
            // timerUpdateBarra
            // 
            this.timerUpdateBarra.Interval = 8;
            this.timerUpdateBarra.Tick += new System.EventHandler(this.timerUpdateBarra_Tick);
            // 
            // labelBarraValue
            // 
            this.labelBarraValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBarraValue.AutoSize = true;
            this.labelBarraValue.BackColor = System.Drawing.Color.Transparent;
            this.labelBarraValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBarraValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarraValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBarraValue.Location = new System.Drawing.Point(747, 70);
            this.labelBarraValue.Name = "labelBarraValue";
            this.labelBarraValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBarraValue.Size = new System.Drawing.Size(45, 24);
            this.labelBarraValue.TabIndex = 12;
            this.labelBarraValue.Text = "50%";
            this.labelBarraValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBar1.Location = new System.Drawing.Point(93, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(693, 42);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 50;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.labelBarraValue);
            this.Controls.Add(this.labelBarra);
            this.Controls.Add(this.labelVoltar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelPergunta);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.buttonSim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 638);
            this.MinimumSize = new System.Drawing.Size(816, 638);
            this.Name = "Form1";
            this.Text = "Conselheiro Amoroso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSim;
        private System.Windows.Forms.Button buttonNao;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelPergunta;
        private RedProgressBar progressBar1;
        private System.Windows.Forms.Label labelVoltar;
        private System.Windows.Forms.Label labelBarra;
        private System.Windows.Forms.Timer timerUpdateBarra;
        private System.Windows.Forms.Label labelBarraValue;
    }
}

