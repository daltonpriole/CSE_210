using System;

public class Registro
{
    private string data;
    private string textPergunta;
    private string textResposta;

    public Registro(string pergunta, string resposta)
    {
        data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        textPergunta = pergunta;
        textResposta = resposta;
    }

    public void Exibir()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"Data: {data}");
        Console.WriteLine($"Pergunta: {textPergunta}");
        Console.WriteLine($"Resposta: {textResposta}");
        Console.WriteLine("========================================");
    }

    public override string ToString()
    {
        return $"Data: {data}\n" +
               $"Pergunta: {textPergunta}\n" +
               $"Resposta: {textResposta}\n" +
               "----------------------------------------";
    }
}