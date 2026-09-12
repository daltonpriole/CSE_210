using System;
//Programa de diário interativo que permite ao usuário registrar respostas a perguntas diárias, exibir registros, salvar e carregar registros de um arquivo.
//Como Implementação de criatividade foi inserido a localização do usuario qdo preenche um registro novo
class Program
{
    static void Main(string[] args)
    {
        bool executando = true;
        string newregistro = "";

        GeradorPerguntas gerador = new GeradorPerguntas();
        Diario diario = new Diario(newregistro);
        
        while (executando)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("       DIÁRIO INTERATIVO");
            Console.WriteLine("=================================");
            Console.WriteLine("1 - Novo registro");
            Console.WriteLine("2 - Exibir registros");
            Console.WriteLine("3 - Salvar Arquivo");
            Console.WriteLine("4 - Carregar arquivo");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("=================================");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();

                    string pergunta = gerador.ObterPergunta();

                    Console.WriteLine("PERGUNTA DO DIA");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(pergunta);
                    Console.WriteLine();

                    Console.Write("Sua resposta: ");
                    string resposta = Console.ReadLine();

                    Console.Write("Sua localização: ");
                    string localizacao = Console.ReadLine();

                    Registro registro = new Registro(
                        pergunta,
                        resposta,
                        localizacao
                    );

                    diario.AdicionarRegistro(registro);

                    Console.WriteLine();
                    Console.WriteLine("Registro salvo com sucesso!");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();

                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine("MEUS REGISTROS");
                    Console.WriteLine();

                    diario.ExibirTodos();

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();

                    break;

                case "3":
                    Console.Clear();
                    Console.Write("Digite o nome do arquivo para salvar os registros (ex: diario.txt): ");
                    string nomeArquivo = Console.ReadLine();

                    diario.SalvarArquivo(nomeArquivo);

                    Console.WriteLine("Registros salvos no arquivo com sucesso!");

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();

                    break;

                case "4":
                    Console.Clear();

                    Console.Write("Digite o nome do arquivo para carregar os registros (ex: diario.txt): ");
                    nomeArquivo = Console.ReadLine();
                    diario.CarregarArquivo(nomeArquivo);

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();

                    break;

                case "5":
                    executando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Diário encerrado.");
    }
}