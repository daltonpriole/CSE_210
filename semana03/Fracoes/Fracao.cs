//Essa Classe Encapsulada fará a manipulação de frações, realizando operações matemáticas como adição, subtração, multiplicação e divisão.
using System;
public class Fracao
{
    private int _numerador;
    private int _denominador;

    //Construtor que inicializa o numerador e denominador da fração em 1/1
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }
    //Construtor que tem como parametro apenas o numerador, inicializando o denominador em 1
    public Fracao(int numeroInteiro)
    {
        _numerador = numeroInteiro;
        _denominador = 1;
    }
    //Construtor que tem dois parametros, numerador e denominador.
    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }
  
    public string ObterFracaoEmTexto()
    {
        string texto = $"{_numerador}/{_denominador}";
        return texto;
    }

    public double ObterFracaoEmDecimal()
    {
        double decimalValue = (double)_numerador / _denominador;
        return decimalValue;
    }

}