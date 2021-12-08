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
    public partial class FormFichaProduto : Form
    {
        public FormFichaProduto()
        {
            InitializeComponent();
        }
        
        internal modelo.produto Registro { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Registro == null) novo();
            else editar();
            this.Dispose();
        }

        private void novo()
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            Registro = new modelo.produto()
            {
                idproduto = tabela.ProximoCodigo(),
                nome = txtNome.Text.ToUpper(),
                preco = Double.Parse(txtPreco.Text),
                idtipo = Int16.Parse(cbTipo.SelectedValue.ToString())
            };

            tabela.inserir(Registro);
        }

        private void editar()
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            Registro = new modelo.produto()
            {
                nome = txtNome.Text.ToUpper(),
                preco = Double.Parse(txtPreco.Text),
                idtipo = Int16.Parse(cbTipo.SelectedValue.ToString()),
            };

            tabela.editar(Registro);
        }

        private void FormFichaProduto_Load(object sender, EventArgs e)
        {
            controle.TipoDB tabela = new controle.TipoDB();
            cbTipo.DataSource = tabela.selectAll();
            cbTipo.ValueMember = "idtipo";
            cbTipo.DisplayMember = "descricao";
            
            if (Registro != null)
            {
                this.Text = "FICHA NÚMERO " + Registro.idproduto;
                txtNome.Text = Registro.nome;
                txtPreco.Text = Registro.preco.ToString();
                cbTipo.SelectedValue = Registro.tipo.ToString();
            }
        }
    }
}
