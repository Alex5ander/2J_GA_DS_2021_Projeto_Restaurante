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
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal)this.MdiParent;
            pai.frProduto = null;
        }
    }
}
