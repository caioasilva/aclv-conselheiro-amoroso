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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonAjuda = new System.Windows.Forms.Button();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(12, 71);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(776, 120);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Iniciar";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // buttonAjuda
            // 
            this.buttonAjuda.Location = new System.Drawing.Point(356, 252);
            this.buttonAjuda.Name = "buttonAjuda";
            this.buttonAjuda.Size = new System.Drawing.Size(75, 23);
            this.buttonAjuda.TabIndex = 1;
            this.buttonAjuda.Text = "Ajuda";
            this.buttonAjuda.UseVisualStyleBackColor = true;
            this.buttonAjuda.Click += new System.EventHandler(this.buttonAjuda_Click);
            // 
            // buttonSobre
            // 
            this.buttonSobre.Location = new System.Drawing.Point(356, 421);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(75, 23);
            this.buttonSobre.TabIndex = 2;
            this.buttonSobre.Text = "Sobre";
            this.buttonSobre.UseVisualStyleBackColor = true;
            this.buttonSobre.Click += new System.EventHandler(this.buttonSobre_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.buttonSobre);
            this.Controls.Add(this.buttonAjuda);
            this.Controls.Add(this.buttonMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 638);
            this.MinimumSize = new System.Drawing.Size(816, 638);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonAjuda;
        private System.Windows.Forms.Button buttonSobre;
    }
}