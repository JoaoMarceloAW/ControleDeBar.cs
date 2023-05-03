using ControleDeBar.cs.Compartilhado;
using ControleDeBar.cs.Mesas;
using ControleDeBar.cs.Produtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Mesas
{
    public class TelaMesa : TelaBase
    {
       
            private RepositorioMesa repositorioMesa;



            public TelaMesa(RepositorioMesa repositorioMesa)

            {
            this.repositorioBase = repositorioMesa;
                this.repositorioMesa = repositorioMesa;


                nomeEntidade = "Mesa";
                sufixo = "s";
            }



            public override string ApresentarMenu()
            {
                Console.Clear();

                Console.WriteLine("Cadastro de Produtos \n");

                Console.WriteLine("Digite 1 para Inserir Mesa");
                Console.WriteLine("Digite 2 para Visualizar Mesa");
                Console.WriteLine("Digite 3 para Editar Mesa");
                Console.WriteLine("Digite 4 para Excluir Mesa");
                Console.WriteLine("Digite s para Sair");

                string opcao = Console.ReadLine();

                return opcao;
            }

            protected override void MostrarTabela(ArrayList registros)
            {
                Console.WriteLine("{0, -10} | {1, -20}", "Id", "Numero");

                Console.WriteLine("---------------------------------------------------------------------------------------");

                foreach (Mesa Mesa in registros)
                {
                    Console.WriteLine("{0, -10} | {1, -20}",
                       Mesa.id, Mesa.numeromesa);
                }
            }

            protected override EntidadeBase ObterRegistro()
            {

                Console.Write("Digite o numero da mesa: ");
            int numeromesa = Convert.ToInt32(Console.ReadLine());

               



                return new Mesa(numeromesa);
            }
        }
    }

