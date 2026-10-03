//Classe filha de Atividade, terapia digital Listagem
using System;

public class Listagem : Atividades
{
    //1.Atributos Privados/Protected
    private List<string> _pergunta;
    private Random _random;

    //2.Construtor
    public Listagem() : base()
    {
        _nome = "Listando";
            _descricao = "Esta atividade vai ajudar você a refletir sobre as coisas boas da sua vida, pedindo que você liste o máximo de coisas que puder em uma determinada área.";
            _random = new Random();

            _pergunta = new List<string>
            {
                "Quem são as pessoas que você aprecia?",
                "Quais são seus pontos fortes pessoais?",
                "Quem são as pessoas que você ajudou esta semana?",
                "Quando você sentiu o Espírito Santo neste mês?",
                "Quem são alguns dos seus heróis pessoais?"
            };
    }

    //3.Métodos Públicos
    public override void Executar()
    {
       string promptEscolhido = _pergunta[_random.Next(_pergunta.Count)];
        Console.WriteLine("\nListe o máximo de respostas que conseguir para a seguinte pergunta:");
        Console.WriteLine($"--- {promptEscolhido} ---");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine(); // Quebra a linha para iniciar a digitação

        int contadorItens = 0;
        DateTime tempoFinal = DateTime.Now.AddSeconds(_duracao);

        // Permite que o usuário insira itens até que o tempo acabe
        while (DateTime.Now < tempoFinal)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
                
            if (!string.IsNullOrEmpty(item))
            {
                contadorItens++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"\nVocê listou {contadorItens} itens. Ótimo trabalho!");
        ExibirProgresso(3);
    }
}