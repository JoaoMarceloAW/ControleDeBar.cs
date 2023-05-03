using ControleDeBar.cs.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Produtos
{
    public class TelaProduto : TelaBase
    {
        private RepositorioProduto repositorioProduto;
     
      

        public TelaProduto(RepositorioProduto repositorioProduto)
        
        {
            this.repositorioBase = repositorioProduto;
            this.repositorioProduto = repositorioProduto;
           

            nomeEntidade = "Produto";
            sufixo = "s";
        }

     

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Produtos \n");

            Console.WriteLine("Digite 1 para Inserir Produto");
            Console.WriteLine("Digite 2 para Visualizar Produtos");
            Console.WriteLine("Digite 3 para Editar Produtos");
            Console.WriteLine("Digite 4 para Excluir Produtos");
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Valor");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Produto Produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}",
                    Produto.id, Produto.nome, Produto.valor);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            int valor = Convert.ToInt32(Console.ReadLine());
                
         

            return new Produto(nome, valor);
        }

       
    }
    
}
