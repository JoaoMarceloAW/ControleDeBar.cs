using ControleDeBar.cs.Cliente;
using ControleDeBar.cs.Compartilhado;
using ControleDeBar.cs.Garçon;
using ControleDeBar.cs.Mesas;
using ControleDeBar.cs.Produtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Conta
{
    public class Conta : EntidadeBase
    {
     public   Mesa mesa;
        public Produto produto;
        public Clientes cliente;
public string cliente1;
        public int mesa1;

        public Conta(Produto produto, , Mesa mesa)
        {
            this.cliente1 = cliente1;
            this.mesa1 = mesa1;
            this.mesa = mesa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta ContaAtualizado = (Conta)registroAtualizado;

            this.cliente1 = ContaAtualizado.cliente1;
            this.mesa1 = ContaAtualizado.mesa1;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(cliente1.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(mesa1.ToString()))
                erros.Add("O campo \"Valor\" é obrigatório");

            return erros;
        }
       

    }
}
