//class Escritura que armazenará as escrituras e devolvera de forma aleatória quando solicitado
using System;
using System.Collections.Generic;
class Escritura 
{
    //1. Atributos Privados(private)
    private Referencia _referencia;
    private List<Palavra> _palavras;

    //2. Construtores Públicos(public)
    public Escritura(Referencia referencia, string texto) {
        // Implementação do construtor da classe Escritura
        _referencia = referencia;
        _palavras = new List<Palavra>();
        // Dividir o texto em palavras e adicionar à lista
        string[] words = texto.Split(' ');
        foreach (string word in words) {
            _palavras.Add(new Palavra(word));
        }
    }

    //3. Métodos Públicos(public)
    public string ObterTexto() {
        // Implementação para obter a referência da escritura
        List<string> textosDasPalavras = new List<string>();
        foreach (Palavra p in _palavras)
        {
            textosDasPalavras.Add(p.ObterTexto());
        }
        string textoCompleto = string.Join(" ", textosDasPalavras);

    return $"{_referencia.ObterTexto()} {textoCompleto}";

    }
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        // Implementação para ocultar palavras aleatórias
        Random random = new Random();
        // O laço roda apenas a quantidade de vezes solicitada
        for (int i = 0; i < numeroParaOcultar; i++)
        {
            // Sorteia um índice válido da lista (de 0 até o total de palavras - 1)
            int indiceSorteado = random.Next(_palavras.Count);
            
            // Pega a palavra que está nessa posição sorteada e oculta ela
            _palavras[indiceSorteado].Ocultar();
        }
    }
    public bool EstaCompletamenteOculta()
    {
        // Implementação para verificar se todas as palavras estão ocultas
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaOculta())
            {
                return false; // Se encontrar uma palavra visível, retorna falso
            }
        }
        return true; // Se todas as palavras estiverem ocultas, retorna verdadeiro
    }




}