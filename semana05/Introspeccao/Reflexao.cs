//Classe filha de Atividade, terapia digital Reflexão
using System;   

public class Reflexao : Atividades
{
    //1.Atributos Privados
    private List<string> _textRefle;
    private List<string> _textPerg;
    

    //2.Construtor
    public Reflexao(string nome, string descricao, int duracao, List<string> textRefle, List<string> textPerg)
        : base(nome, descricao, duracao)
    {
        _textRefle = textRefle;
        _textPerg = textPerg;
        _textRefle.Add("Texto de reflexão 1");
        _textPerg.Add("Pergunta de reflexão 1");
    }

    //3.Métodos Públicos
    public override void Executar()
    {
        Console.WriteLine($"Iniciando a atividade de reflexão: {_nome}");
        Console.WriteLine($"Descrição: {_descricao}");
        Console.WriteLine($"Duração: {_duracao} minutos");
    
        // Lógica para iniciar a atividade de reflexão
    }
    public string ObterTextoReflexaoRandon()
    {
        // Lógica para obter o texto de reflexão
        return "Texto de reflexão";
    }
    public string ObterTextoPerguntaRandon()
    {
        // Lógica para obter a pergunta de reflexão
        return "Pergunta de reflexão";
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