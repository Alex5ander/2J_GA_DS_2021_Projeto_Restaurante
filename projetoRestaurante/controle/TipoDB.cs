using prjRestaurante.controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoRestaurante.controle
{
    class TipoDB
    {
        string con = Conexao.Open("localhost", "restaurantedb", "root", "minas");
        public object selectAll()
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.tipo orderby linhas.idtipo select linhas;

                return query.ToList();
            }
        }

        public void inserir(modelo.tipo reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                banco.tipo.Add(reg);
                banco.SaveChanges();
            }
        }

        public void editar(modelo.tipo reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.tipo Velho = banco.tipo.First(i => i.idtipo == reg.idtipo);
                banco.Entry(Velho).CurrentValues.SetValues(reg);
                banco.SaveChanges();
            }
        }

        public void excluir(modelo.tipo reg)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                modelo.tipo Velho = banco.tipo.First(i => i.idtipo == reg.idtipo);
                banco.tipo.Remove(Velho);
                banco.SaveChanges();
            }
        }
    }
}
