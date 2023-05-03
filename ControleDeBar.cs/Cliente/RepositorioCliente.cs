using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Cliente
{
    public class RepositorioCliente : RepositorioBase
    {

        public RepositorioCliente(ArrayList ListaDeClientes)
        {
           this.listaRegistros = ListaDeClientes;
        }

        public override Clientes SelecionarPorId(int id)
        {
            return (Clientes)base.SelecionarPorId(id);
        }


    }
}
