namespace projetoRestaurante.visao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCardapio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnMesas,
            this.mnCardapio,
            this.mnSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(98, 261);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnProdutos.Image")));
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(85, 35);
            this.mnProdutos.Text = "PRODUTOS";
            this.mnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnProdutos.Click += new System.EventHandler(this.mnProdutos_Click);
            // 
            // mnMesas
            // 
            this.mnMesas.Image = ((System.Drawing.Image)(resources.GetObject("mnMesas.Image")));
            this.mnMesas.Name = "mnMesas";
            this.mnMesas.Size = new System.Drawing.Size(85, 35);
            this.mnMesas.Text = "MESAS";
            this.mnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnCardapio
            // 
            this.mnCardapio.Image = ((System.Drawing.Image)(resources.GetObject("mnCardapio.Image")));
            this.mnCardapio.Name = "mnCardapio";
            this.mnCardapio.Size = new System.Drawing.Size(85, 35);
            this.mnCardapio.Text = "CARDAPIO";
            this.mnCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnSair
            // 
            this.mnSair.Image = ((System.Drawing.Image)(resources.GetObject("mnSair.Image")));
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(85, 35);
            this.mnSair.Text = "SAIR";
            this.mnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "CONTROLE DE RESTAURANTE V 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnMesas;
        private System.Windows.Forms.ToolStripMenuItem mnCardapio;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
    }
}