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
        if (_estaOculta)
        {
            return "____"; // Retorna um espaço em branco ou algum marcador para palavras ocultas
        }
        else
        {
            return _texto; // Retorna o texto da palavra se não estiver oculta
        }
    }
}