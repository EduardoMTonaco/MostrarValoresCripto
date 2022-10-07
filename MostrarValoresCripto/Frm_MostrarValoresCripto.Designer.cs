namespace MostrarValoresCripto
{
    partial class Frm_MostrarValoresCripto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MostrarValoresCripto));
            this.Txb_MostrarCripto = new System.Windows.Forms.TextBox();
            this.Btn_CheckCripto = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Pgs_Progresso = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Tempo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txb_MostrarCripto
            // 
            this.Txb_MostrarCripto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_MostrarCripto.Location = new System.Drawing.Point(12, 43);
            this.Txb_MostrarCripto.Multiline = true;
            this.Txb_MostrarCripto.Name = "Txb_MostrarCripto";
            this.Txb_MostrarCripto.ReadOnly = true;
            this.Txb_MostrarCripto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txb_MostrarCripto.Size = new System.Drawing.Size(324, 186);
            this.Txb_MostrarCripto.TabIndex = 0;
            // 
            // Btn_CheckCripto
            // 
            this.Btn_CheckCripto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CheckCripto.Location = new System.Drawing.Point(12, 272);
            this.Btn_CheckCripto.Name = "Btn_CheckCripto";
            this.Btn_CheckCripto.Size = new System.Drawing.Size(143, 30);
            this.Btn_CheckCripto.TabIndex = 1;
            this.Btn_CheckCripto.Text = "Btn_CheckCripto";
            this.Btn_CheckCripto.UseVisualStyleBackColor = true;
            this.Btn_CheckCripto.Click += new System.EventHandler(this.Btn_CheckCripto_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(180, 272);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(156, 30);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Btn_Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Pgs_Progresso
            // 
            this.Pgs_Progresso.Location = new System.Drawing.Point(13, 236);
            this.Pgs_Progresso.Name = "Pgs_Progresso";
            this.Pgs_Progresso.Size = new System.Drawing.Size(323, 23);
            this.Pgs_Progresso.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Lbl_Tempo
            // 
            this.Lbl_Tempo.AutoSize = true;
            this.Lbl_Tempo.Location = new System.Drawing.Point(12, 317);
            this.Lbl_Tempo.Name = "Lbl_Tempo";
            this.Lbl_Tempo.Size = new System.Drawing.Size(60, 13);
            this.Lbl_Tempo.TabIndex = 5;
            this.Lbl_Tempo.Text = "Lbl_Tempo";
            // 
            // Frm_MostrarValoresCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 339);
            this.Controls.Add(this.Lbl_Tempo);
            this.Controls.Add(this.Pgs_Progresso);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_CheckCripto);
            this.Controls.Add(this.Txb_MostrarCripto);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_MostrarValoresCripto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MostrarValoresCripto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_MostrarCripto;
        private System.Windows.Forms.Button Btn_CheckCripto;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.ProgressBar Pgs_Progresso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label Lbl_Tempo;
    }
}

