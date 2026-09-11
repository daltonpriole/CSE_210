using System;

//Classe GeradorPerguntas - Gera perguntas para o diário
public class GeradorPerguntas
{
    private List<string> _perguntas; // Lista de perguntas

    public GeradorPerguntas()
    {
        _perguntas = new List<string>
        {
            "O que você aprendeu hoje?",
            "Qual foi o ponto alto do seu dia?",
            "Houve algum desafio que você superou?",
            "Como você se sentiu durante o dia?",
            "O que você poderia ter feito melhor?"
        };
    }

    public string ObterPergunta()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        return _perguntas[index];
    }
}