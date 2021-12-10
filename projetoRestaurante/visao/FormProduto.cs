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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormFichaProduto ficha = new FormFichaProduto();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                modelo.produto p = (modelo.produto) tabela.pesquisar(ficha.Registro.idproduto);
                bs.Add(p);
                bs.ResetBindings(false);
                bs.MoveLast();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormFichaProduto ficha = new FormFichaProduto();
            ficha.Registro = (modelo.produto) bs.Current;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {   
                bs.ResetBindings(false);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op;
            modelo.produto p = (modelo.produto)bs.Current;
            op = MessageBox.Show("Apaga " + p.nome, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(op == DialogResult.Yes)
            {
                controle.ProdutoDB tabela = new controle.ProdutoDB();
                tabela.excluir(p.idproduto);
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
