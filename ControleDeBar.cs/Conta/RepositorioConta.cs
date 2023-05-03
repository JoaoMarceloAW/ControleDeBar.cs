using ControleDeBar.cs.Cliente;
using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Conta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList ListaDeConta)
        {
            this.listaRegistros = ListaDeConta;
        }

        public override Conta SelecionarPorId(int id)
        {
            return (Conta)base.SelecionarPorId(id);
        }
    }
}
