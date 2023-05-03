using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.cs.Compartilhado
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle de Medicamentos 1.0\n");

            Console.WriteLine("Digite 1 para Cadastrar Produtos");
            Console.WriteLine("Digite 2 para Cadastrar Mesas");
            Console.WriteLine("Digite 3 para Cadastrar Garcon");
            Console.WriteLine("Digite 4 para Cadastrar Clientes");
            Console.WriteLine("Digite 5 para Cadastrar Contas");


            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }


    }
}
