//Classe para gerenciar o menu e acoes do usuário.

using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorMetas
{
    //Atributos
    private List<Metas> _metas;
    private int _pontosTotais;

    //Construtor
    public GerenciadorMetas()
    {
        _metas = new List<Metas>();
        _pontosTotais = 0;
    }

    //Métodos
    public void ExibirInfoJogador()
    {
        // ELEMENTO DE CRIATIVIDADE: Sistema Dinâmico de Nível e Patentes baseado em XP/Pontos
        int nivel = (_pontosTotais);
        string patente = " ";

        if (nivel >= 150) patente = "Mestre Celestial";
        else if (nivel >= 100) patente = "Buscador de Sabedoria";
        else if (nivel >= 70) patente = "Mestre da Persistência";
        else if (nivel >= 50) patente = "Guerreiro da Persistência";
        else if (nivel >= 30) patente = "Aventureiro Determinado";
        else if (nivel >= 10) patente = "Explorador Iniciante";
        else patente = "Novato";

        Console.WriteLine($"[Jogador] Pontos Atuais: {_pontosTotais} XP | Nível: {nivel} ({patente})");
    }

    public void Iniciar()
    {
        //Menu principal do usuário
        string opcao = "";
        while (opcao != "6")
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE METAS ETERNAS ===");
            ExibirInfoJogador();
            Console.WriteLine();
            Console.WriteLine("1. Criar Nova Meta");
            Console.WriteLine("2. Listar Metas");
            Console.WriteLine("3. Registrar Evento");
            Console.WriteLine("4. Salvar Metas");
            Console.WriteLine("5. Carregar Metas");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": CriarMeta(); break;
                case "2": ListarDetalhesMetas(); break;
                case "3": RegistrarEvento(); break;
                case "4": SalvarMetas(); break;
                case "5": CarregarMetas(); break;
                case "6": Console.WriteLine("\nAté logo! Continue sua Missão Eterna."); break;
                default: Console.WriteLine("Opção inválida! Pressione qualquer tecla."); Console.ReadKey(); break;
            }
        }
    }

    public void ListarNomesMetas()
    {
        Console.WriteLine("Lista de Metas:");
        foreach (var meta in _metas)
        {
            Console.WriteLine(meta.Nome);
        }
    }

    private void ListarDetalhesMetas()
    {
        Console.Clear();
        Console.WriteLine("=== Suas Metas ===");
        if (_metas.Count == 0)
        {
            Console.WriteLine("Nenhuma meta cadastrada ainda.");
        }
        else
        {
            for (int i = 0; i < _metas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhes()}");
            }
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    public void CriarMeta()
    {
        Console.Clear();
        Console.WriteLine("=== Criar Nova Meta ===");
        Console.WriteLine("1. Meta Simples");
        Console.WriteLine("2. Meta Eterna");
        Console.WriteLine("3. Meta de Lista de Tarefas");
        Console.Write("Escolha o tipo: ");
        string tipo = Console.ReadLine();

        Console.Write("Qual o nome da meta? ");
        string nome = Console.ReadLine();
        Console.Write("Qual a descrição curta dela? ");
        string descricao = Console.ReadLine();
        Console.Write("Quantos pontos valem por registro? (1-10) ");
        int pontos = int.Parse(Console.ReadLine());

        if (tipo == "1")
        {
            _metas.Add(new Simples(false, nome, descricao, pontos));
        }
        else if (tipo == "2")
        {
            _metas.Add(new Eterna(nome, descricao, pontos, 0));
        }
        else if (tipo == "3")
        {
            Console.Write("Quantas vezes essa meta precisa ser realizada? ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("Qual o bônus de pontos ao concluir totalmente? ");
            int bonus = int.Parse(Console.ReadLine());
            _metas.Add(new ListaTarefas(0, total, bonus, nome, descricao, pontos));
        }

        Console.WriteLine("\nMeta criada com sucesso! Pressione qualquer tecla.");
        Console.ReadKey();
    }

    private void RegistrarEvento()
        {
            Console.Clear();
            Console.WriteLine("=== Registrar Progresso de Meta ===");
            if (_metas.Count == 0)
            {
                Console.WriteLine("Não há metas para registrar progresso.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < _metas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_metas[i].Nome}");
            }

            Console.Write("Qual meta você realizou? (Digite o número): ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < _metas.Count)
            {
                int pontosGanhos = _metas[indice].RegistrarEvento();
                if (pontosGanhos > 0)
                {
                    _pontosTotais += pontosGanhos;
                    Console.WriteLine($"\n🎉 Parabéns! Você ganhou {pontosGanhos} pontos!");
                }
                else
                {
                    Console.WriteLine("\nEsta meta já foi totalmente concluída e não gera mais pontos.");
                }
            }
            else
            {
            Console.WriteLine("\nNúmero de meta inválido.");
            }
            Console.ReadKey();
        }

    private void SalvarMetas()
        {   
            Console.Write("Digite o nome do arquivo para salvar (Ex: metas.txt): ");
            string nomeArquivo = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(nomeArquivo))
            {
                writer.WriteLine(_pontosTotais); // Salva a pontuação total na primeira linha
                foreach (var meta in _metas)
                {
                    writer.WriteLine(meta.ObterRepresentacao());
                }
            }  
        Console.WriteLine("Dados salvos com sucesso! Pressione qualquer tecla.");
        Console.ReadKey();
    }

private void CarregarMetas()
    {
        Console.Clear();
        Console.WriteLine("=== Carregar Metas ===");
        Console.Write("Digite o nome do arquivo para carregar (Ex: metas.txt): ");
        string nomeArquivo = Console.ReadLine();
        if (!File.Exists(nomeArquivo))
        {
            Console.WriteLine("Arquivo não encontrado! Pressione qualquer tecla.");
            Console.ReadKey();
            return;
        }
        _metas.Clear();
        using (StreamReader reader = new StreamReader(nomeArquivo))
        {
            _pontosTotais = int.Parse(reader.ReadLine()); // Lê a pontuação inicial
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                string[] partes = linha.Split('|');
                string tipo = partes[0];
                if (tipo == "MetaSimples")
                {
                    _metas.Add(new Simples(bool.Parse(partes[4]), partes[1], partes[2], int.Parse(partes[3])));
                }
                else if (tipo == "MetaEterna")
                {
                    _metas.Add(new Eterna(partes[1], partes[2], int.Parse(partes[3]), int.Parse(partes[4])));
                }
                else if (tipo == "MetaDeListaDeTarefas")
                {
                    _metas.Add(new ListaTarefas(int.Parse(partes[3]), int.Parse(partes[5]), int.Parse(partes[6]), partes[2], partes[1], int.Parse(partes[3])));
                }
            }
        }
        Console.WriteLine("Metas carregadas com sucesso! Pressione qualquer tecla.");
        Console.ReadKey();
    }   

}