using System;
using System.Collections.Generic;

public class GeradorPerguntas
{
    private List<string> _pergunta;

    private Random random;

    public GeradorPerguntas()
    {
        _pergunta = new List<string>()
        {
            "Como foi seu dia hoje?",
            "Qual foi a melhor coisa que aconteceu hoje?",
            "O que você aprendeu hoje?",
            "Existe algo que você gostaria de melhorar amanhã?",
            "Pelo que você é grato hoje?",
            "Qual foi o momento mais importante do seu dia?",
            "Como você está se sentindo hoje?",
            "O que fez você sorrir hoje?",
            "Qual foi o maior desafio que você enfrentou hoje?",
            "O que você gostaria de lembrar deste dia?"
        };

        random = new Random();
    }

    public string ObterPergunta()
    {
        int indice = random.Next(_pergunta.Count);

        return _pergunta[indice];
    }
}