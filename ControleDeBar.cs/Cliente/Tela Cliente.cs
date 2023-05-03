using ControleDeBar.cs.Compartilhado;
using ControleDeBar.cs.Cliente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeBar.cs.Cliente;

namespace ControleDeBar.cs.Cliente
{
    public class TelaCliente : TelaBase
    {
        private RepositorioCliente repositorioCliente;



        public TelaCliente(RepositorioCliente repositorioCliente)

        {
            this.repositorioBase = repositorioCliente;
            this.repositorioCliente = repositorioCliente;


            nomeEntidade = "Cliente";
            sufixo = "s";
        }



        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Clientes \n");

            Console.WriteLine("Digite 1 para Inserir Cliente");
            Console.WriteLine("Digite 2 para Visualizar Clientes");
            Console.WriteLine("Digite 3 para Editar Clientes");
            Console.WriteLine("Digite 4 para Excluir Clientes");
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Valor");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Clientes Cliente in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20}",
                    Cliente.id, Cliente.nome);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

          

            return new Clientes(nome);
        }

    }
}
