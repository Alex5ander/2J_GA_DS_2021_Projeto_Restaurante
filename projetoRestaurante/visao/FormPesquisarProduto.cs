using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoRestaurante.visao
{
    public partial class FormPesquisarProduto : Form
    {
        internal int Cod {get; set;}
        public FormPesquisarProduto()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            dgvLista.DataSource = tabela.pesquisarNome(txtNome.Text);
            dgvLista.AutoResizeColumns();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(dgvLista.Rows.Count != 0)
            {
                Cod = Int16.Parse(dgvLista.CurrentRow.Cells["Codigo"].Value.ToString());
                this.Dispose();
            }
        }
    }
}
