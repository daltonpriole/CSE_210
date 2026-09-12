using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    private List<Registro> _registro;

    private string arquivo;

    public Diario(string registro)
    {
        _registro = new List<Registro>();
    }

    public void AdicionarRegistro(Registro novo)
    {
        _registro.Add(novo);
    }

    public void ExibirTodos()
    {
        if (_registro.Count == 0)
        {
            Console.WriteLine("Nenhum registro encontrado.");
            return;
        }

        foreach (Registro registro in _registro)
        {
            registro.Exibir();
        }
    }

    public void SalvarArquivo(string nomeArquivo)
    {
        arquivo = nomeArquivo;

        using (StreamWriter escritor = new StreamWriter(arquivo, false))
        {
            foreach (Registro registro in _registro)
            {
                escritor.WriteLine(registro.ToString());
            }
        }
    }

    public void CarregarArquivo(string nomeArquivo)
    {
        if (!File.Exists(nomeArquivo))
        {
            return;
        }

        string[] linhas = File.ReadAllLines(nomeArquivo);

        Console.WriteLine("Registros encontrados no arquivo:");
        Console.WriteLine();

        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }
}