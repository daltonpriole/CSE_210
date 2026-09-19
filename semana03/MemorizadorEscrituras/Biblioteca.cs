//Classe que contem as escrituras para memorizar
using System;
using System.Collections.Generic;

public class Biblioteca
{
    //1. Atributos Privados
    private List<Escritura> _escrituras;

    //2. Construtores Publicos
    public Biblioteca()
    {
        _escrituras = new List<Escritura>();
    }

    // 3. Métodos Públicos
    public void AdicionarEscritura(Escritura escritura)
    {
        _escrituras.Add(escritura);
    }

    public void ExibirOpcoes()
    {
        Console.WriteLine("Escrituras disponíveis:");
        for (int i = 0; i < _escrituras.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_escrituras[i].ObterTextoDaReferencia()}");
        }
    }

    public Escritura ObterEscritura(int escolhaDoUsuario)
    {
        return _escrituras[escolhaDoUsuario - 1];
    }

}