using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Cliente
{
    public class Clientes : EntidadeBase
    {
     public   string nome;

        public Clientes(string? nome)
        {
            this.nome = nome;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Clientes ClientesAtualizado = (Clientes)registroAtualizado;

            this.nome = ClientesAtualizado.nome;
           
        }

      

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

          
            return erros;
        }
    }
}
