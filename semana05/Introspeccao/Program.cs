// Atividade de Introspecção Semana 05 - CSE 210 
// Autor: Dalton Priore
// Implemantado a mais uma mudanca de tempo na atividade de respiração, para desacelerar a respiração, começando rápido e terminando devagar.
// Criado uma nova atividade de gratidao, que permite ao usuário listar coisas pelas quais é grato, e também uma atividade de reflexão, que permite ao usuário refletir sobre momentos de sua vida em que demonstrou força e resiliência.
using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                // Menu
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("  1. Iniciar a atividade de respiração");
                Console.WriteLine("  2. Iniciar a atividade de reflexão");
                Console.WriteLine("  3. Iniciar a atividade de listagem");
                Console.WriteLine("  4. Iniciar a atividade de gratidão");
                Console.WriteLine("  5. Sair");
                Console.Write("Seleciona uma das opções do menu: ");

                string opcao = Console.ReadLine();
                Atividades atividadeSelecionada = null;

                switch (opcao)
                {
                    case "1":
                        atividadeSelecionada = new Respiracao();
                        break;
                    case "2":
                        atividadeSelecionada = new Reflexao();
                        break;
                    case "3":
                        atividadeSelecionada = new Listagem();
                        break;
                    case "4":
                        atividadeSelecionada = new Gratidao();
                        break;
                    case "5":
                        continuar = false;
                        continue;
                    default:
                        Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        continue;
                }

                if (atividadeSelecionada != null)
                {
                    atividadeSelecionada.ExibirMsgInicial();
                    
                    // Chama o Executar específico de cada classe filha de forma automática
                    atividadeSelecionada.Executar(); 
                    
                    atividadeSelecionada.ExibirMsgFinal();
                }
            }
        }
    }

