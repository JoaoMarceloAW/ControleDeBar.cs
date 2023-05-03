using ControleDeBar.cs.Cliente;
using ControleDeBar.cs.Compartilhado;
using ControleDeBar.cs.Garçon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Conta
{
    public class TelaConta : TelaBase
    {
        public TelaConta(RepositorioConta repositorioConta)

        {
            this.repositorioBase = repositorioBase;



            nomeEntidade = "Conta";
            sufixo = "s";
        }



        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Conta \n");

            Console.WriteLine("Digite 1 para Inserir Conta");
            Console.WriteLine("Digite 2 para Visualizar Conta");
            Console.WriteLine("Digite 3 para Editar Conta");
            Console.WriteLine("Digite 4 para Excluir Conta");
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Cliente", "Mesa");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Conta Conta in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}",
                    Conta.id, Conta.cliente, Conta.mesa);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {

            Console.Write("Digite o nome do cliente: ");
            string cliente = Console.ReadLine();

            Console.Write("Digite o numero da mesa: ");
            int mesa = Convert.ToInt32(Console.ReadLine());



            return new Conta(cliente,mesa);
        }
    }
}
