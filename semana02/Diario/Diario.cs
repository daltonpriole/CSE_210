using System;
using System.Collections.Generic;

//Classe Diario - Representa um diário de atividades diárias
public class Diario
{
    public string _nome; // Nome do diário
    public List<Registro> _registros; // Lista de registros diários

    public Diario()
    {
        _registros = new List<Registro>();
    }

    public void AdicionarRegistro(Registro registro)
    {
        _registros.Add(registro);
    }

    public void SalvarEmArquivo(string nomeArquivo)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(nomeArquivo))
        {
            file.WriteLine($"Diário: {_nome}");
            file.WriteLine("Registros:");
            foreach (var registro in _registros)
            {
                file.WriteLine($"Data: {registro._data}");
                file.WriteLine($"Pergunta: {registro._textPergunta}");
                file.WriteLine($"Resposta: {registro._textResposta}");
                file.WriteLine(); // Adiciona uma linha em branco entre os registros
            }
        }
    }

    public void CarregarDeArquivo(string nomeArquivo)
    {
        if (System.IO.File.Exists(nomeArquivo))
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(nomeArquivo))
            {
                _nome = file.ReadLine().Replace("Diário: ", "");
                file.ReadLine(); // Pula a linha "Registros:"
                _registros.Clear();

                while (!file.EndOfStream)
                {
                    Registro registro = new Registro();
                    registro._data = file.ReadLine().Replace("Data: ", "");
                    registro._textPergunta = file.ReadLine().Replace("Pergunta: ", "");
                    registro._textResposta = file.ReadLine().Replace("Resposta: ", "");
                    _registros.Add(registro);
                    file.ReadLine(); // Pula a linha em branco entre os registros
                }
            }
        }
        else
        {
            Console.WriteLine($"O arquivo '{nomeArquivo}' não foi encontrado.");
        }
    }

    public void ExibirTodosOsRegistros()
    {
        Console.WriteLine($"Diário: {_nome}");
        Console.WriteLine("Registros:");
        foreach (var registro in _registros)
        {
            registro.ExibirRegistro();
            Console.WriteLine(); // Adiciona uma linha em branco entre os registros
        }
    }
}