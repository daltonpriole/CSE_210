//Class Palavra que armazenará as palavras das escrituras
using System;
class Palavra
{
    //1. Atributos Privados(private)
    private string _texto;
    private bool _estaOculta;

    //2. Construtores Públicos(public)
    public Palavra(string texto) {
        // Implementação do construtor da classe Palavra
        _texto = texto;
        _estaOculta = false; // Inicializa a palavra como visível
    }


    //3. Métodos Públicos(public)
    public void Ocultar() {
        // Implementação para ocultar a palavra
        _estaOculta = true;
    }
    public void Exibir() {
        // Implementação para exibir a palavra
        _estaOculta = false;
    }
    public bool EstaOculta() {
        // Implementação para verificar se a palavra está oculta
        return _estaOculta;
    }
    public string ObterTexto() {
        // Implementação para obter o texto da palavra
        if (_estaOculta) // Retorna um sublinhado pra cada letra das palavras ocultas
        {
            return new string('_', _texto.Length);
        }
        else // Retorna o texto da palavra
        {
            return _texto; 
        }
    }
}