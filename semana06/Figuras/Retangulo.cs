//Classe filha de Figura 

using System;

class Retangulo : Figura
{
    //1.Atributos
    private double _comprimento;
    private double _largura;

    //2.Construtor
    public Retangulo(string cor, double comprimento, double largura) : base(cor)
    {
        _comprimento = comprimento;
        _largura = largura;
    }

    //3.Métodos
    public override double ObterArea()
    {
        return _comprimento * _largura;
    }
}