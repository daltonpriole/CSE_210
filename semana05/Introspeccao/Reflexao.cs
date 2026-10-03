//Classe filha de Atividade, terapia digital Reflexão
using System;   

public class Reflexao : Atividades
{
    //1.Atributos Privados
    private List<string> _textRefle;
    private List<string> _textPerg;
    private Random _random;

    //2.Construtor
    public Reflexao() : base()
    {
        _nome = "Reflexão";
        _descricao = "Esta atividade vai ajudar você a refletir sobre momentos da sua vida em que demonstrou força e resiliência. Isso vai ajudar você a reconhecer o poder que possui e como pode usá-lo em outros aspectos da sua vida.";
        _random = new Random();
        // Inicializa as duas listas
        _textRefle = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
        };

        _textPerg = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência que se aplica a outras situações?",
            "O que você aprendeu sobre si mesmo por meio dessa experiência?",
            "Como você pode manter essa experiência em mente no futuro?"
        };

    }


    //3.Métodos Públicos
    public override void Executar()
    {
        string promptEscolhido = _textRefle[_random.Next(_textRefle.Count)];
        Console.WriteLine("\nReflita sobre a seguinte frase:");
        Console.WriteLine($"\n--- {promptEscolhido} ---\n");
        Console.WriteLine("Quando tiver algo em mente, pressione enter para continuar.");
        Console.ReadLine();
        Console.WriteLine("Agora reflita sobre cada uma das seguintes perguntas a seguir em relação a essa experiência.");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.Clear();

        DateTime tempoFinal = DateTime.Now.AddSeconds(_duracao);

        while (DateTime.Now < tempoFinal)
        {
            string perguntaEscolhida = _textPerg[_random.Next(_textPerg.Count)];
            Console.Write($"> {perguntaEscolhida} ");
            ExibirProgresso(5);
            Console.WriteLine();
        }
    }
    public string ObterTextoReflexaoRandon()
    {
        // Lógica para obter o texto de reflexão
        int index = _random.Next(_textRefle.Count);
        return _textRefle[index];
    }
    public string ObterTextoPerguntaRandon()
    {
        // Lógica para obter a pergunta de reflexão
        int index = _random.Next(_textPerg.Count);
        return _textPerg[index];
    }
    public void ExibirReflexoes()
    {
        string textoReflexao = ObterTextoReflexaoRandon();
        Console.WriteLine($"Texto de Reflexão: {textoReflexao}");
    }
    public void ExibirPerguntas()
    {
        string perguntaReflexao = ObterTextoPerguntaRandon();
        Console.WriteLine($"Pergunta de Reflexão: {perguntaReflexao}");
    }
}