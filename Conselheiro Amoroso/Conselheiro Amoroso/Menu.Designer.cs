namespace Conselheiro_Amoroso
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMain
            // 
            this.buttonMain.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.bt_iniciar;
            this.buttonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMain.FlatAppearance.BorderSize = 0;
            this.buttonMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMain.Location = new System.Drawing.Point(91, 292);
            this.buttonMain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(319, 106);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            this.buttonMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMain_MouseDown);
            this.buttonMain.MouseEnter += new System.EventHandler(this.buttonMain_MouseEnter);
            this.buttonMain.MouseLeave += new System.EventHandler(this.buttonMain_MouseLeave);
            this.buttonMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMain_MouseUp);
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.bt_ajuda;
            this.buttonAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAjuda.FlatAppearance.BorderSize = 0;
            this.buttonAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAjuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjuda.Location = new System.Drawing.Point(91, 402);
            this.buttonAjuda.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(156, 86);
            this.buttonAjuda.TabIndex = 1;
            this.buttonAjuda.UseVisualStyleBackColor = true;
            this.buttonAjuda.Click += new System.EventHandler(this.buttonAjuda_Click);
            this.buttonAjuda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAjuda_MouseDown);
            this.buttonAjuda.MouseEnter += new System.EventHandler(this.buttonAjuda_MouseEnter);
            this.buttonAjuda.MouseLeave += new System.EventHandler(this.buttonAjuda_MouseLeave);
            this.buttonAjuda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAjuda_MouseUp);
            // 
            // buttonSobre
            // 
            this.buttonSobre.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.bt_sobre;
            this.buttonSobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSobre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSobre.FlatAppearance.BorderSize = 0;
            this.buttonSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSobre.Location = new System.Drawing.Point(254, 402);
            this.buttonSobre.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(156, 86);
            this.buttonSobre.TabIndex = 2;
            this.buttonSobre.UseVisualStyleBackColor = true;
            this.buttonSobre.Click += new System.EventHandler(this.buttonSobre_Click);
            this.buttonSobre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSobre_MouseDown);
            this.buttonSobre.MouseEnter += new System.EventHandler(this.buttonSobre_MouseEnter);
            this.buttonSobre.MouseLeave += new System.EventHandler(this.buttonSobre_MouseLeave);
            this.buttonSobre.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSobre_MouseUp);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Help;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(635, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 47);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Conselheiro_Amoroso.Properties.Resources.menu;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}