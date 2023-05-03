using ControleDeBar.cs.Cliente;
using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Mesas
{
    public class RepositorioMesa : RepositorioBase
    {
        public RepositorioMesa(ArrayList ListaDeMesa)
        {
            this.listaRegistros = ListaDeMesa;
        }

        public override Mesa SelecionarPorId(int id)
        {
            return (Mesa)base.SelecionarPorId(id);
        }
    }
}
