using System;

public class Registro
{
    private string _data;
    private string _textPergunta;
    private string _textResposta;
    private string _localizacao;

    public Registro(string pergunta, string resposta, string localizacao)
    {
        _data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        _textPergunta = pergunta;
        _textResposta = resposta;
        _localizacao = localizacao;
    }

    public void Exibir()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Pergunta: {_textPergunta}");
        Console.WriteLine($"Resposta: {_textResposta}");
        Console.WriteLine($"Localização: {_localizacao}");
        Console.WriteLine("========================================");
    }

    public override string ToString()
    {
        return $"Data: {_data}\n" +
               $"Pergunta: {_textPergunta}\n" +
               $"Resposta: {_textResposta}\n" +
               $"Localização: {_localizacao}\n" +
               "----------------------------------------";
    }
}