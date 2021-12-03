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
    public partial class FormProduto : Form
    {

        public List<modelo.produto> Produtos { get; set; }
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal)this.MdiParent;
            pai.frProduto = null;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            Produtos = (List<modelo.produto>) tabela.selectAll();
            bs.DataSource = Produtos;
            lbId.DataBindings.Add(new Binding("Text", bs, "idproduto"));
            lbProduto.DataBindings.Add(new Binding("Text", bs, "nome"));
            lbPreco.DataBindings.Add(new Binding("Text", bs, "preco"));
            lbTipo.DataBindings.Add(new Binding("Text", bs, "tipo.descricao"));
        }
    }
}
