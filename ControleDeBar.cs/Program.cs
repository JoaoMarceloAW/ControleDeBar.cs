using ControleDeBar.cs.Cliente;
using ControleDeBar.cs.Compartilhado;
using ControleDeBar.cs.Conta;
using ControleDeBar.cs.Garçon;
using ControleDeBar.cs.Mesas;
using ControleDeBar.cs.Produtos;
using System.Collections;

namespace ControleDeBar.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioConta reposiotorioConta = new RepositorioConta(new ArrayList());
            RepositorioGarcon reposiotorioGarcon = new RepositorioGarcon(new ArrayList());
             TelaPrincipal telaPrincipal = new TelaPrincipal();
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            TelaProduto telaproduto = new TelaProduto(repositorioProduto);
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaGarcon telaGarcon = new TelaGarcon(reposiotorioGarcon);
            TelaConta telaConta = new TelaConta(reposiotorioConta);
            RepositorioCliente reposiotorioCliente = new RepositorioCliente(new ArrayList());
            TelaCliente telaCliente = new TelaCliente(reposiotorioCliente);

            string opcao = telaPrincipal.ApresentarMenu();

            while (true)
                if (opcao == "1")
                {
                    string subMenu = telaproduto.ApresentarMenu();
                    if (opcao == "s")
                        break;

                    if (subMenu == "1")
                    {
                        telaproduto.InserirNovoRegistro();

                    }

                    else if (subMenu == "2")
                    {
                        telaproduto.VisualizarRegistros(true);
                        Console.ReadLine();

                    }

                    else if (subMenu == "3")
                    {
                        telaproduto.EditarRegistro();

                    }

                    else if (subMenu == "4")
                    {
                        telaproduto.ExcluirRegistro();

                    }

                }
                else if (opcao == "2")
                {
                    string subMenu = telaMesa.ApresentarMenu();
                    if (subMenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();

                    }

                    else if (subMenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();

                    }

                    else if (subMenu == "3")
                    {
                        telaMesa.EditarRegistro();

                    }

                    else if (subMenu == "4")
                    {
                        telaMesa.ExcluirRegistro();

                    }

                }
                else if (opcao == "3")
                {
                    string subMenu = telaGarcon.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcon.InserirNovoRegistro();

                    }

                    else if (subMenu == "2")
                    {
                        telaGarcon.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaGarcon.EditarRegistro();

                    }

                    else if (subMenu == "4")
                    {
                        telaGarcon.ExcluirRegistro();

                    }

                }
                else if (opcao == "4")
                {
                    string subMenu = telaCliente.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaCliente.InserirNovoRegistro();

                    }

                    else if (subMenu == "2")
                    {
                        telaCliente.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaCliente.EditarRegistro();

                    }

                    else if (subMenu == "4")
                    {
                        telaCliente.ExcluirRegistro();

                    }
                }
                else if (opcao == "5")
                {
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.InserirNovoRegistro();

                    }

                    else if (subMenu == "2")
                    {
                        telaConta.VisualizarRegistros(true);
                        Console.ReadLine();
                    }

                    else if (subMenu == "3")
                    {
                        telaConta.EditarRegistro();

                    }

                    else if (subMenu == "4")
                    {
                        telaConta.ExcluirRegistro();

                    }
                }

            }
           


        }


    }
