using System;

// Classe Registro - Representa um registro de atividades diárias

public class Registro
{
    public string _data; // Data do registro
    public string _textPergunta; // Pergunta do registro
    public string _textResposta; // Resposta do registro 

    public void ExibirRegistro()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Pergunta: {_textPergunta}");
        Console.WriteLine($"Resposta: {_textResposta}");
    }
}

