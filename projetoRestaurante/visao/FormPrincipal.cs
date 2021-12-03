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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormProduto frProduto;

        private void mnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnProdutos_Click(object sender, EventArgs e)
        {
            if (frProduto == null)
            {
                frProduto = new FormProduto();
                frProduto.MdiParent = this;
                frProduto.Location = new Point(0, 0);
                frProduto.Show();
             
            }
        }

    }
}
