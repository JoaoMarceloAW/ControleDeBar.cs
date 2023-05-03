using ControleDeBar.cs.Cliente;
using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Produtos
{
    public class RepositorioProduto : RepositorioBase
    {
        public RepositorioProduto(ArrayList ListaDeProduto)
        {
            this.listaRegistros = ListaDeProduto;
        }

        public override Produto SelecionarPorId(int id)
        {
            return (Produto)base.SelecionarPorId(id);
        }
    }
}
