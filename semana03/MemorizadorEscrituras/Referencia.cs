//Class Referencia que armazenará as referências das escrituras
using System;
public class Referencia
{
    //1. Atributos Privados(private)
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    //2. Construtores Públicos(public)
    public Referencia(string livro, int capitulo, int versiculo) {
        // Implementação do construtor da classe Referencia
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
    }
    public Referencia(string livro, int capitulo, int versiculo, int ultimoVersiculo) {
        // Implementação do construtor da classe Referencia
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo = ultimoVersiculo;
    }

    //3. Métodos Públicos(public)
    public string ObterTexto()
    {
        // Implementação para obter o texto da referência
        if (_ultimoVersiculo > 0)
        {
            return $"{_livro} {_capitulo}:{_versiculo}-{_ultimoVersiculo}";
        }
        else
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }
    }
}
