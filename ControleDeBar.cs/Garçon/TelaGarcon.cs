using ControleDeBar.cs.Compartilhado;
using ControleDeBar.cs.Garçon;
using ControleDeBar.cs.Garçon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Garçon
{
    public class TelaGarcon : TelaBase
    {
        private RepositorioGarcon repositorioGarcon;



        public TelaGarcon(RepositorioGarcon repositorioGarcon)

        {
            this.repositorioBase = repositorioGarcon;
            this.repositorioGarcon = repositorioGarcon;


            nomeEntidade = "Garcon";
            sufixo = "s";
        }



        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Produtos \n");

            Console.WriteLine("Digite 1 para Inserir Garcon");
            Console.WriteLine("Digite 2 para Visualizar Garcon");
            Console.WriteLine("Digite 3 para Editar Garcon");
            Console.WriteLine("Digite 4 para Excluir Garcon");
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20}", "Id", "Nome");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Garcon Garcon in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20}",
                   Garcon.id, Garcon.nome);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {

            Console.Write("Digite o numero da Garcon: ");
            string nome = Console.ReadLine();

                





            return new Garcon(nome);
        }
    }
}
