//Classe Pai 

using System;

public abstract class Figura
{
    //1.Atributos
    protected string _cor;

    //2.Construtor
    public Figura(string cor)
    {
        _cor = cor;
    }

    //3.Métodos
    public string obterCor()
    {
        return _cor;
    }
    public void DefinirCor(string cor)
    {
        _cor = cor;
    }
    abstract public double ObterArea();

}