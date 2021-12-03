using prjRestaurante.controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRestaurante.controle
{
    class ProdutoDB
    {
        string con = Conexao.Open("localhost", "restaurantedb", "root", "minas");

        public object selectAll()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.produto.Include("tipo") orderby linhas.idproduto select linhas;

                return query.ToList();
            }
        }

        public void inserir(modelo.produto reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                banco.produto.Add(reg);
                banco.SaveChanges();
            }
        }

        public void editar(modelo.produto reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.produto Velho = banco.produto.First(i => i.idproduto == reg.idproduto);
                banco.Entry(Velho).CurrentValues.SetValues(reg);
                banco.SaveChanges();
            }
        }

        public void excluir(modelo.produto reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.produto Velho = banco.produto.First(i => i.idproduto == reg.idproduto);
                banco.produto.Remove(Velho);
                banco.SaveChanges();
            }
        }

    }
}
