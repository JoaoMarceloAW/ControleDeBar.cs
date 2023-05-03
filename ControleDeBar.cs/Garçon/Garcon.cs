using ControleDeBar.cs.Compartilhado;
using ControleDeBar.cs.Produtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Garçon
{
    public class Garcon : EntidadeBase
    {
      public  string nome;

        public Garcon(string nome)
        {
            this.nome = nome;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcon GarconAtualizado = (Garcon)registroAtualizado;

            this.nome = GarconAtualizado.nome;


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
