﻿namespace Conselheiro_Amoroso
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonAjuda = new System.Windows.Forms.Button();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new Conselheiro_Amoroso.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // buttonMain
            // 
            this.buttonMain.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMain.Location = new System.Drawing.Point(116, 296);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(197, 96);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Iniciar";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.Location = new System.Drawing.Point(116, 398);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(100, 23);
            this.buttonAjuda.TabIndex = 1;
            this.buttonAjuda.Text = "Ajuda";
            this.buttonAjuda.UseVisualStyleBackColor = true;
            this.buttonAjuda.Click += new System.EventHandler(this.buttonAjuda_Click);
            // 
            // buttonSobre
            // 
            this.buttonSobre.Location = new System.Drawing.Point(222, 398);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(91, 23);
            this.buttonSobre.TabIndex = 2;
            this.buttonSobre.Text = "Sobre";
            this.buttonSobre.UseVisualStyleBackColor = true;
            this.buttonSobre.Click += new System.EventHandler(this.buttonSobre_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.oculos;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Help;
            this.panel1.Location = new System.Drawing.Point(520, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 76);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.menu;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSobre);
            this.Controls.Add(this.buttonAjuda);
            this.Controls.Add(this.buttonMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 638);
            this.MinimumSize = new System.Drawing.Size(816, 638);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conselheiro Amoroso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonAjuda;
        private System.Windows.Forms.Button buttonSobre;
        private System.Windows.Forms.Timer timer1;
        private DoubleBufferPanel panel1;
    }
}