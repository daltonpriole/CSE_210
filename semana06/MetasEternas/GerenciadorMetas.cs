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
    public void Iniciar()
    {
        //Menu principal do usuário
        string opcoes;
        do
        {
            Console.WriteLine("Menu de Metas:");
            Console.WriteLine("1. Criar NovaMeta");
            Console.WriteLine("2. Listar Metas");
            Console.WriteLine("3. Salvar Metas");
            Console.WriteLine("4. Carregar Metas");
            Console.WriteLine("5. Registrar Evento");
            Console.WriteLine("6. Sair");
            
            Console.Write("Escolha uma opção: ");
            opcoes = Console.ReadLine();

        }while (opcoes != "6");
        
    }

    public void ExibirPontosTotais()
    {
        Console.WriteLine($"Pontos Totais: {_pontosTotais}");
    }

    public void ListarNomesMetas()
    {
        Console.WriteLine("Lista de Metas:");
        foreach (var meta in _metas)
        {
            Console.WriteLine(meta.Nome);
        }
    }

    public void ListarDetalhesMetas()
    {
        Console.WriteLine("Detalhes das Metas:");
        foreach (var meta in _metas)
        {
            Console.WriteLine(meta.ObterDetalhes());
        }
    }

    public void CriarMeta()
    {
        //Criar uma nova meta com base na escolha do usuário
        Console.WriteLine("Escolha o tipo de meta a ser criada:");
        Console.WriteLine("1. Meta Simples");
        Console.WriteLine("2. Meta Eterna");
        Console.WriteLine("3. Lista de Tarefas");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        Console.Write("Digite o nome da meta: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a descrição da meta: ");
        string descricao = Console.ReadLine();
        Console.Write("Digite os pontos da meta: ");
        int pontos = int.Parse(Console.ReadLine());

        if (opcao == "1")
        {
            _metas.Add(new Simples(false, nome, descricao, pontos));
        }
        else if (opcao == "2")
        {
            _metas.Add(new Eterna(nome, descricao, pontos));
        }
        else if (opcao == "3")
        {
            int concluidas;
            Console.Write("Quantas vezes essa meta precisa ser concluida para o bonus: ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do bônus da meta: ");
            int bonus = int.Parse(Console.ReadLine());
            concluidas = 0; // Inicializa o número de tarefas concluídas como 0
            _metas.Add(new ListaTarefas(concluidas, total, bonus, nome, descricao, pontos));
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    public void RegistrarEvento()
    {
        Console.WriteLine("Escolha a meta para registrar o evento:");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].Nome}");
        }
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine()) - 1;

        if (opcao >= 0 && opcao < _metas.Count)
        {
            Metas metaSelecionada = _metas[opcao];
            metaSelecionada.RegistrarEvento();
            if (metaSelecionada.EstaConcluida())
            {
                int pontosGanhos = metaSelecionada.Pontos;
                _pontosTotais += pontosGanhos;
            }
            else
            {
                Console.WriteLine("Evento registrado, mas a meta ainda não foi concluída.");
            }
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    public void SalvarMetas()
    {
        //salvar metas em um arquivo .txt
        Console.Write("Digite o nome do arquivo para salvar as metas: ");
        string nomeArquivo = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            foreach (var meta in _metas)
            {
                writer.WriteLine(meta.ObterDetalhes());
            }
        }
        Console.WriteLine("Metas salvas com sucesso!");

    }

    public void CarregarMetas()
    {
        //Carregar metas de um arquivo .txt salvo anteriormente
        Console.Write("Digite o nome do arquivo para carregar as metas: ");
        string nomeArquivo = Console.ReadLine();
        using (StreamReader reader = new StreamReader(nomeArquivo))
        {
            string linha;
            while ((linha = reader.ReadLine()) != null)
            {
                // Processar cada linha do arquivo e criar objetos Meta
            }
        }
        Console.WriteLine("Metas carregadas com sucesso!");

    }

}