using ControleDeBar.cs.Cliente;
using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Garçon
{
    public class RepositorioGarcon : RepositorioBase
    {
        public RepositorioGarcon(ArrayList ListaDeGarcon)
        {
            this.listaRegistros = ListaDeGarcon;
        }

        public override Garcon SelecionarPorId(int id)
        {
            return (Garcon)base.SelecionarPorId(id);
        }
    }
}
