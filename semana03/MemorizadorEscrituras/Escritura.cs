//class Escritura que armazenará as escrituras e devolvera de forma aleatória quando solicitado
using System;
using System.Collections.Generic;
public class Escritura 
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
    public string ObterTextoDaReferencia()
    {
        return _referencia.ObterTexto();
    }
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        // Implementação para ocultar palavras aleatórias
        Random random = new Random();
        List<Palavra> palavrasVisiveis = new List<Palavra>(); // Lista para armazenar as palavras visíveis
        // Adiciona apenas as palavras visíveis à lista
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaOculta())
            {
                palavrasVisiveis.Add(p);
            }
        }
        // O laço roda apenas a quantidade de vezes solicitada
        for (int i = 0; i < numeroParaOcultar; i++)
        {
            // Sorteia um índice válido da lista (de 0 até o total de palavras - 1)
            int indiceSorteado = random.Next(palavrasVisiveis.Count);

            // Pega a palavra que está nessa posição sorteada e oculta ela
            palavrasVisiveis[indiceSorteado].Ocultar();

            // 1. Remove a palavra que acabou de ocultar para não sorteá-la de novo no próximo loop
            palavrasVisiveis.RemoveAt(indiceSorteado);

            // 2. Se não sobrou nenhuma palavra visível na lista, interrompe o 'for' imediatamente
            if (palavrasVisiveis.Count == 0) break;
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