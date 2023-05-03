using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Mesas
{
    public class Mesa : EntidadeBase
    {
      public int numeromesa;
     

        public Mesa(int numeromesa)
        {
            this.numeromesa = numeromesa;
        }

      
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa MesaAtualizado = (Mesa)registroAtualizado;

            this.numeromesa = MesaAtualizado.numeromesa;
           
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            

            if (string.IsNullOrEmpty(numeromesa.ToString()))
                erros.Add("O campo \"Valor\" é obrigatório");

            return erros;
        }
    }

   
}
