
namespace projetoRestaurante.visao
{
    partial class FormPesquisarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarProduto));
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(747, 203);
            this.pnTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 32);
            this.panel1.Size = new System.Drawing.Size(747, 140);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(747, 76);
            this.panel2.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.Location = new System.Drawing.Point(16, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(715, 21);
            this.txtNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Size = new System.Drawing.Size(715, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOME DO PRODUTO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESQUISA DE NOME DO PRODUTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.dgvLista);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 203);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(747, 247);
            this.pnBottom.TabIndex = 1;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(0, 0);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(747, 247);
            this.dgvLista.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAbrir);
            this.panel3.Controls.Add(this.btnPesquisar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(298, 32);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.panel3.Size = new System.Drawing.Size(449, 76);
            this.panel3.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(232, 0);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Padding = new System.Windows.Forms.Padding(8);
            this.btnAbrir.Size = new System.Drawing.Size(201, 76);
            this.btnAbrir.TabIndex = 9;
            this.btnAbrir.Text = "ABRIR FICHA";
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(16, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(8);
            this.btnPesquisar.Size = new System.Drawing.Size(201, 76);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FormPesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisarProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISAR";
            this.pnTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnPesquisar;
    }
}